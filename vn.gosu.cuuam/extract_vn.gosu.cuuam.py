import struct
from dataclasses import dataclass
from io import BytesIO
import zlib
import os

@dataclass
class FileInfo:
    idk2: int
    offset: int
    uncompressedSize: int
    dataSize: int
    idk3: int
    idk4: int
    whatever: int
    file_name: str

@dataclass
class Header:
    signature: bytes
    ver: int
    idk: int
    fileCount: int
    infoEnd: int
    idkByte: int
    files: list[FileInfo]

def read_cstring(f: BytesIO) -> str:
    chars = []
    while True:
        b = f.read(1)
        if not b or b == b'\x00':
            break
        chars.append(b)
    return b"".join(chars).decode("utf-8", errors="ignore")

def load_header(filename: str) -> Header:
    with open(filename, "rb") as f:
        data = BytesIO(f.read())

    signature = data.read(4)
    ver = struct.unpack("<I", data.read(4))[0]
    idk = struct.unpack("<h", data.read(2))[0]
    fileCount = struct.unpack("<I", data.read(4))[0]
    infoEnd = struct.unpack("<I", data.read(4))[0]
    idkByte = data.read(1)[0]

    files = []
    for _ in range(fileCount):
        idk2 = struct.unpack("<h", data.read(2))[0]
        offset = struct.unpack("<q", data.read(8))[0]
        uncompressedSize = struct.unpack("<I", data.read(4))[0]
        dataSize = struct.unpack("<I", data.read(4))[0]
        idk3 = struct.unpack("<I", data.read(4))[0]
        idk4 = struct.unpack("<I", data.read(4))[0]
        whatever = data.read(1)[0]
        file_name = read_cstring(data)

        files.append(FileInfo(idk2, offset, uncompressedSize, dataSize, idk3, idk4, whatever, file_name))

    return Header(signature, ver, idk, fileCount, infoEnd, idkByte, files), data

def extract_files(package_path: str, output_folder: str):
    header, data = load_header(package_path)
    os.makedirs(output_folder, exist_ok=True)

    for fi in header.files:
        data.seek(fi.offset)
        raw = data.read(fi.dataSize)

        try:
            decompressed = zlib.decompress(raw)
        except zlib.error:
            decompressed = raw

        full_path = os.path.join(output_folder, fi.file_name.replace("/", os.sep))
        os.makedirs(os.path.dirname(full_path), exist_ok=True)

        # Encode Lua files, binary otherwise
        if fi.file_name.lower().endswith(".lua"):
            try:
                decompressed_text = decompressed.decode("gbk")
            except UnicodeDecodeError:
                decompressed_text = decompressed.decode("utf-8", errors="replace")
            with open(full_path, "w", encoding="utf-8") as out_file:
                out_file.write(decompressed_text)
        else:
            with open(full_path, "wb") as out_file:
                out_file.write(decompressed)

        print(f"[+] Extracted: {full_path} ({len(decompressed)} bytes)")

# ------------------------------
# Example usage
# ------------------------------
package_path = r"D:\Users\ASUS\Downloads\IDA9.0\vn.gosu.cuuam\res.package"
output_folder = r"D:\Users\ASUS\Downloads\IDA9.0\vn.gosu.cuuam\extracted_files"

extract_files(package_path, output_folder)
