#!/usr/bin/env python3
"""
Decrypt global-metadata.dat

Algorithm (sub_155330):
  1. Skip first 8 bytes
  2. XOR 0x66 on bytes 0x0008..0x0FFF
  3. AES-128-CBC decrypt 0x4000 at offset 0x1000 (8 blocks x 0x800, fresh IV each)
  4. XOR 0x66 on 0x4000 blocks per 0x10000 page from offset 0x11000 + remainder

Key: section_id=0xD96603C0 -> AES key="d96603c0d96603c0", XOR key=0x66
"""

import sys, os
from Crypto.Cipher import AES


def decrypt_metadata(data, section_id):
    xor_key = (section_id >> 16) & 0xFF
    if xor_key == 0:
        xor_key = 0x87
    aes_key = ("%08x%08x" % (section_id, section_id)).encode("ascii")
    iv = bytes([2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17])

    result = bytearray(data)
    file_size = len(data)

    # XOR from byte 8 to 0xFFF
    for i in range(8, min(0x1000, file_size)):
        result[i] ^= xor_key

    # AES-CBC decrypt 0x4000 at offset 0x1000
    for blk_off in range(0, 0x4000, 0x800):
        actual_off = 0x1000 + blk_off
        if actual_off + 0x800 <= file_size:
            block = bytes(result[actual_off : actual_off + 0x800])
            cipher = AES.new(aes_key, AES.MODE_CBC, iv=iv)
            result[actual_off : actual_off + 0x800] = cipher.decrypt(block)

    # XOR 0x4000 per 0x10000 page from 0x11000 + remainder
    xored_start = 0x11000
    if xored_start < file_size:
        remaining = file_size - xored_start
        page_off = 0
        while remaining >= (page_off + 0x10000):
            xor_pos = xored_start + page_off
            for i in range(0x4000):
                result[xor_pos + i] ^= xor_key
            page_off += 0x10000
        rem_start = xored_start + page_off
        rem_size = remaining - page_off
        for i in range(rem_size):
            result[rem_start + i] ^= xor_key

    return bytes(result)


if __name__ == "__main__":
    if len(sys.argv) < 2:
        print(f"Usage: python {sys.argv[0]} <input> [output] [section_id] [version]")
        print(f"  input:      path to global-metadata.dat")
        print(f"  output:     output path (default: input_decrypted.dat)")
        print(f"  section_id: hex key (default: 0xD96603C0)")
        print(f"  version:    set magic AF 1B B1 FA + version LE u32 at bytes 4-8")
        sys.exit(1)

    input_file = sys.argv[1]
    output_file = sys.argv[2] if len(sys.argv) > 2 else None
    section_id = int(sys.argv[3], 0) if len(sys.argv) > 3 else 0xD96603C0
    version = int(sys.argv[4]) if len(sys.argv) > 4 else None

    with open(input_file, "rb") as f:
        data = f.read()

    print(f"Input: {input_file} ({len(data) / 1048576:.1f} MB)")
    print(f"Key: 0x{section_id:08X}")

    result = bytearray(decrypt_metadata(data, section_id))

    if version is not None:
        result[0:4] = b"\xaf\x1b\xb1\xfa"
        result[4:8] = version.to_bytes(4, "little")
        print(f"Set magic + version: AF 1B B1 FA {version.to_bytes(4, 'little').hex()}")

    magic = result[0:4]
    valid = magic == bytes([0xAF, 0x1B, 0xB1, 0xFA])
    print(f"Magic: {magic.hex()} ({'VALID' if valid else 'UNKNOWN'})")

    out = output_file or os.path.splitext(input_file)[0] + "_decrypted.dat"
    with open(out, "wb") as f:
        f.write(result)
    print(f"Written: {out} ({len(result) / 1048576:.1f} MB)")
