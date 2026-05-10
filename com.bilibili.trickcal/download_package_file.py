#!/usr/bin/env python3
"""
Unified script for Trickcal - uses client version 1.3.1
- Fetch server info
- Download, decompress (no decrypt), parse package index → generate package URLs
- Download, decrypt, decompress asset index → save plain
- Download, decrypt, decompress table index → parse & generate table file URLs
"""

import os
import json
import struct
import zlib
import hashlib
import requests
from Crypto.Cipher import AES
import io

# ------------------------------------------------------------------
# Decryption (exact port of GameCrypto.DecryptAGUtilStream)
# ------------------------------------------------------------------
def decrypt_agutil_stream(data: bytes, filename: str = "unknown") -> bytes:
    if len(data) < 16:
        raise ValueError("Data too short, missing IV")
    iv = data[:16]
    encrypted_body = data[16:]

    key_bytes = b"b1l1bili"
    int_bytes = bytes([
        key_bytes[0] ^ iv[15],
        key_bytes[1] ^ iv[14],
        key_bytes[2] ^ iv[13],
        key_bytes[3] ^ iv[12],
    ])
    X = struct.unpack('<I', int_bytes)[0]

    password = f"b1l1bili{X}"
    aes_key = hashlib.sha256(password.encode('utf-8')).digest()

    try:
        cipher = AES.new(aes_key, AES.MODE_CBC, iv=iv)
        decrypted = cipher.decrypt(encrypted_body)
        pad_len = decrypted[-1]
        if pad_len < 1 or pad_len > 16:
            raise ValueError("Invalid padding")
        return decrypted[:-pad_len]
    except Exception as e:
        print(f"[WARN] {filename}: AES decrypt failed – {e}. Returning raw data.")
        return data

# ------------------------------------------------------------------
# Decompression (raw DEFLATE)
# ------------------------------------------------------------------
def decompress_raw_deflate(data: bytes) -> bytes:
    return zlib.decompress(data, -15)

# ------------------------------------------------------------------
# 1. Fetch server info (extended) – client version fixed to 1.3.1
# ------------------------------------------------------------------
def get_server_info(client_version="1.3.1", platform_id="2", channel_id="2001"):
    url = "https://l13-ob-va-gs-trickcal.bilibiligame.net/bili/get-server-info"
    headers = {
        "User-Agent": "UnityPlayer/2022.3.56f1 (UnityWebRequest/1.0, libcurl/8.10.1-DEV)",
        "Accept": "*/*",
        "Accept-Encoding": "deflate, gzip",
        "Content-Type": "application/x-www-form-urlencoded",
        "X-Unity-Version": "2022.3.56f1",
    }
    data = {
        "platform-id": platform_id,
        "channel-id": channel_id,
        "client-version": client_version,
    }
    resp = requests.post(url, headers=headers, data=data)
    resp.raise_for_status()
    outer = resp.json()

    def decode_nested(obj):
        if isinstance(obj, str):
            try:
                return decode_nested(json.loads(obj))
            except:
                return obj
        elif isinstance(obj, dict):
            return {k: decode_nested(v) for k, v in obj.items()}
        elif isinstance(obj, list):
            return [decode_nested(i) for i in obj]
        else:
            return obj

    decoded = decode_nested(outer)
    msg = decoded.get("msg", {})
    cdn_list = msg.get("cdn_list", "")
    packages_res_version = msg.get("packages_resource_version")
    resource_version = msg.get("resource_version")        # e.g. "8.572"
    table_version = msg.get("table_version")              # e.g. "RLS_31_32_120_4fdb3f074"
    table_text_version = msg.get("table_text_version")              # e.g. "RLS_31_32_120_4fdb3f074"
    return cdn_list, packages_res_version, resource_version, table_version,table_text_version

# ------------------------------------------------------------------
# 2. Generic download helper with caching
# ------------------------------------------------------------------
def download_file(url, cache_filename, cache_dir="."):
    cache_path = os.path.join(cache_dir, cache_filename)
    if os.path.exists(cache_path):
        print(f"  Using cached: {cache_path}")
        with open(cache_path, "rb") as f:
            return f.read()
    else:
        print(f"  Downloading: {url}")
        resp = requests.get(url, headers={"Accept-Encoding": "gzip, deflate"})
        resp.raise_for_status()
        data = resp.content
        with open(cache_path, "wb") as f:
            f.write(data)
        print(f"  Saved to: {cache_path}")
        return data

# ------------------------------------------------------------------
# 3. Parse package index (decompressed only, not encrypted)
# ------------------------------------------------------------------
def parse_package_index(plain_data):
    stream = io.BytesIO(plain_data)
    records = []
    while stream.tell() < len(plain_data):
        tag = struct.unpack('<I', stream.read(4))[0]
        if tag == 1:
            # Package name (varint length)
            length = 0
            shift = 0
            while True:
                b = stream.read(1)[0]
                length |= (b & 0x7F) << shift
                shift += 7
                if not (b & 0x80):
                    break
            pkg_name = stream.read(length).decode('utf-8')
            records.append(('package', pkg_name))
        elif tag == 0:
            # File entry
            path_len = struct.unpack('<I', stream.read(4))[0]
            rel_path = stream.read(path_len).decode('utf-8')
            offset = struct.unpack('<q', stream.read(8))[0]
            size = struct.unpack('<q', stream.read(8))[0]
            # Hash (varint length)
            hlen = 0
            shift = 0
            while True:
                b = stream.read(1)[0]
                hlen |= (b & 0x7F) << shift
                shift += 7
                if not (b & 0x80):
                    break
            hash_str = stream.read(hlen).decode('utf-8')
            records.append(('file', rel_path, size, offset, hash_str))
        else:
            print(f"Unknown tag {tag} at offset {stream.tell()-4}")
            break
    return records

# ------------------------------------------------------------------
# 4. Parse table index (list of varint-length strings) – but it's actually TSV
#    We'll read as plain text because v.index after decryption is a TSV file.
# ------------------------------------------------------------------
def parse_table_index(plain_data):
    # The plain_data is a UTF-8 text file: first line count, then lines with "filename\thash"
    text = plain_data.decode('utf-8', errors='ignore')
    lines = text.strip().splitlines()
    if not lines:
        return []
    # First line may be a count
    entries = []
    for line in lines[1:]:  # skip count line
        if '\t' in line:
            filename = line.split('\t')[0]
            entries.append(filename)
    return entries

# ------------------------------------------------------------------
# 5. Process and save generic index (decrypt + decompress)
# ------------------------------------------------------------------
def process_encrypted_index(url, cache_name, output_name):
    print(f"\nProcessing {output_name}...")
    raw_data = download_file(url, cache_name)
    decrypted = decrypt_agutil_stream(raw_data, cache_name)
    plain = decompress_raw_deflate(decrypted)
    with open(output_name, "wb") as f:
        f.write(plain)
    print(f"  Plain saved to: {output_name}")
    return plain

# ------------------------------------------------------------------
# 6. Main
# ------------------------------------------------------------------
def main():
    # Force client version to 1.3.1 (no other version)
    CLIENT_VERSION = "1.3.1"
    print(f"Using client version: {CLIENT_VERSION}")
    cdn_list, packages_version, resource_version, table_version, table_text_version = get_server_info(client_version=CLIENT_VERSION)
    if not cdn_list or not packages_version:
        print("Failed to get server info.")
        return

    first_cdn = cdn_list.split(';')[0].strip()
    print(f"First CDN: {first_cdn}")
    print(f"Packages version: {packages_version}")
    print(f"Resource version: {resource_version}")
    print(f"Table version: {table_version}")

    # ------------------------------------------------------------------
    # Package index: download, decompress (NO decrypt), parse
    # ------------------------------------------------------------------
    package_index_url = f"{first_cdn}/ab/packages/{packages_version}/Android/index.data"
    cache_filename = f"index_{packages_version}.data"
    print(f"\n=== Processing Package Index (no decryption) ===")
    raw_index = download_file(package_index_url, cache_filename)
    decompressed_index = decompress_raw_deflate(raw_index)

    records = parse_package_index(decompressed_index)

    parsed_output = f"parsed_index_{packages_version}.txt"
    with open(parsed_output, "w", encoding="utf-8") as out:
        current_pkg = None
        for rec in records:
            if rec[0] == 'package':
                current_pkg = rec[1]
                pkg_url = f"{first_cdn}/ab/packages/{packages_version}/Android/{current_pkg}.abp"
                out.write(f"\nPackage: {current_pkg} -> {pkg_url}\n")
            else:
                out.write(f"  File: {rec[1]}, size: {rec[2]}, offset: {rec[3]}, hash: {rec[4]}\n")
    print(f"Parsed package index saved to: {parsed_output}")

    # ------------------------------------------------------------------
    # Asset index (Android.index) – encrypted + compressed
    # ------------------------------------------------------------------
    if resource_version:
        asset_index_url = f"{first_cdn}/ab/Android/{resource_version}/Android.index"
        asset_cache = f"Android_{resource_version}.index.enc"
        asset_output = f"Android_{resource_version}.index.plain"
        process_encrypted_index(asset_index_url, asset_cache, asset_output)
    else:
        print("No resource_version, skipping asset index.")

    # ------------------------------------------------------------------
    # Table index (v.index) – encrypted + compressed → parse & generate URLs
    # ------------------------------------------------------------------
    if table_version:
        table_index_url = f"{first_cdn}/table/{table_version}/v.index"
        table_cache = f"v_{table_version}.index.enc"
        table_output = f"v_{table_version}.index.plain"
        plain_table = process_encrypted_index(table_index_url, table_cache, table_output)

        # Parse table index (first line is count, then each line: filename TAB hash)
        text = plain_table.decode('utf-8', errors='ignore')
        lines = text.strip().splitlines()
        if len(lines) > 1:
            table_urls_file = f"table_{table_version}_urls.txt"
            with open(table_urls_file, "w", encoding="utf-8") as out:
                # Skip the first line (count) if it looks like a number
                start = 1 if lines[0].isdigit() else 0
                for line in lines[start:]:
                    if '\t' in line:
                        filename = line.split('\t')[0]
                        url = f"{first_cdn}/table/{table_version}/{filename}"
                        out.write(f"{url}\n")
            print(f"Table file URLs saved to: {table_urls_file}")
        else:
            print("No table entries found, maybe different format?")
    
    else:
        print("No table_version, skipping table index.")
    if table_version:
        table_index_url = f"{first_cdn}/table_text/{table_text_version}/v_text.index"
        table_cache = f"v_{table_text_version}.v_text.index.enc"
        table_output = f"v_{table_text_version}.v_text.index.plain"
        plain_table = process_encrypted_index(table_index_url, table_cache, table_output)

        # Parse table index (first line is count, then each line: filename TAB hash)
        text = plain_table.decode('utf-8', errors='ignore')
        lines = text.strip().splitlines()
        if len(lines) > 1:
            table_urls_file = f"table_text_{table_version}_urls.txt"
            with open(table_urls_file, "w", encoding="utf-8") as out:
                # Skip the first line (count) if it looks like a number
                start = 1 if lines[0].isdigit() else 0
                for line in lines[start:]:
                    if '\t' in line:
                        filename = line.split('\t')[0]
                        url = f"{first_cdn}/table_text/{table_text_version}/{filename}"
                        out.write(f"{url}\n")
            print(f"Table file URLs saved to: {table_urls_file}")
        else:
            print("No table entries found, maybe different format?")
    
    else:
        print("No table_version, skipping table index.")

    print("\nAll done.")

if __name__ == "__main__":
    main()