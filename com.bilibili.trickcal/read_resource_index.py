#!/usr/bin/env python3
"""
Parse data index file (compressed with raw DEFLATE).

"""

import struct
import zlib

def read_varint(f):
    """Read a .NET-style variable-length integer (7-bit groups, little-endian)."""
    value = 0
    shift = 0
    while True:
        b = f.read(1)
        if not b:
            raise EOFError
        b = b[0]
        value |= (b & 0x7F) << shift
        shift += 7
        if not (b & 0x80):
            break
    return value

def read_string(f):
    """Read a varint-length UTF-8 string."""
    length = read_varint(f)
    return f.read(length).decode('utf-8')

def parse_packinfo_file(compressed_path):
    with open(compressed_path, 'rb') as f:
        compressed = f.read()

    # Raw DEFLATE (no zlib/gzip headers) – wbits = -15
    decompressed = zlib.decompress(compressed, -15)

    import io
    stream = io.BytesIO(decompressed)
    records = []

    while stream.tell() < len(decompressed):
        tag = struct.unpack('<I', stream.read(4))[0]

        if tag == 1:
            # Package name record
            pkg_name = read_string(stream)
            records.append(('package', pkg_name))
        elif tag == 0:
            # File entry record
            path_len = struct.unpack('<I', stream.read(4))[0]
            rel_path = stream.read(path_len).decode('utf-8')
            size = struct.unpack('<q', stream.read(8))[0]
            offset = struct.unpack('<q', stream.read(8))[0]
            hash_str = read_string(stream)
            records.append(('file', rel_path, size, offset, hash_str))
        else:
            print(f"Unknown tag {tag} at position {stream.tell()-4}")
            break

    return records

def main():
    import sys
    if len(sys.argv) < 2:
        print(f"Usage: {sys.argv[0]} <packinfo.data>")
        sys.exit(1)

    records = parse_packinfo_file(sys.argv[1])

    for rec in records:
        if rec[0] == 'package':
            print(f"Package: {rec[1]}")
        elif rec[0] == 'file':
            print(f"  File: {rec[1]}, size: {rec[2]}, offset: {rec[3]}, hash: {rec[4]}")

if __name__ == '__main__':
    main()