import struct
from pyzuc import *

key = b"Touch Your Heart"
iv = bytes.fromhex("a4 39 8b b5 7c 3a 4c d7 93 8d f3 e7 82 78 13 5a")

zuc_initialization(key, iv)

raw_ks = zuc_generatekeystream(40)

num_full_words = len(raw_ks) // 4
words = struct.unpack(f'<{num_full_words}I', raw_ks)
ks_bytes = struct.pack(f'>{num_full_words}I', *words)

def bytes_to_u32_list(data):
    return [
        int.from_bytes(data[i:i+4], "little")
        for i in range(0, len(data), 4)
    ]

def dec_bit(value, keystream):
    """
    Unified DEC/DEC2:
    - auto detects 32-bit vs 64-bit based on value size
    - uses exact same bit logic as binary
    """

    bit_size = value.bit_length()
    limit = 64 if bit_size > 32 else 32

    n0x40 = 32 * 40
    if limit > n0x40:
        limit = n0x40

    for i in range(limit):
        ks_word = keystream[i >> 5]
        ks_bit = (ks_word >> (i & 31)) & 1
        val_bit = (value >> i) & 1

        if val_bit == ks_bit:
            value &= ~(1 << i)
        else:
            value |= (1 << i)

    return value
encrypted = bytes.fromhex("""
68 8F 75 B8 DB 83 18 0C DB 83 1B AB DB 83 19 E0
EE AD 63 8D 10 00 E9 B3 29 92 46 BC 5B 89 04 4E
14 00 DB 83 1B E2 DB 83 1B F8 00 00 00 00 00 00
00 00 00 00
""")

keystream = bytes_to_u32_list(ks_bytes)

enc_size    = encrypted[0:8]
enc_version = encrypted[8:12]
enc_flags   = encrypted[12:16]

size_val    = int.from_bytes(enc_size, "big")
version_val = int.from_bytes(enc_version, "big")
flags_val   = int.from_bytes(enc_flags, "big")

dec_size    = dec_bit(size_val, keystream)
dec_version = dec_bit(version_val, keystream)
dec_flags   = dec_bit(flags_val, keystream)
print("=== RESULT ===")
print("size   :", hex(dec_size))
print("version:", hex(dec_version))
print("flags  :", hex(dec_flags))