#!/usr/bin/env python3
"""
HandleStream RC4-like decryption using actual byte_13130 table
extracted from disassembly.
"""

import binascii
import sys

BYTE_13130_HEX = (
    "4bd45de66ff8810a931ca52eb740c930db646876ff88119a23ac35be47d059e26bf47d066f18a12ab33cc54ed7603172"
    "fb320d966fa8317843cc55de4c73790244149d263138c14ad35ce56ef78009921ba42db63fc851da63ec75fe873899594"
    "7344246cf58e157f37c058e4ea0294b3bc44dd65fe871fa830c951ea730b942cb543166ef78018a429c6aae4cc049d25b"
    "e46d427f75911aa32c773ec750d962eb74fd86369821aa69bc6ace38e069f27b398d169f28b13a534cd55ee77078820b4"
    "a1d382f4e41ca536e6573770089129b59ad69bf48d15ae36cf57e079070a22b363dc64fd8616e73fc850e9720a932bb44"
    "cd56df73f17a038c159e27b031c2"
)

BYTE_13130 = list(binascii.unhexlify(BYTE_13130_HEX))
assert len(BYTE_13130) == 256, f"Expected 256 bytes, got {len(BYTE_13130)}"


def ksa(s_init):
    """Key Scheduling Algorithm using byte_13130 as key material."""
    S = list(range(256))
    j = 0
    for i in range(256):
        j = (j + S[i] + s_init[i]) & 0xFF
        S[i], S[j] = S[j], S[i]
    return S


def prga(S, data):
    """Pseudo-Random Generation Algorithm (RC4-style stream)."""
    i = j = 0
    out = bytearray(len(data))
    for n in range(len(data)):
        i = (i + 1) & 0xFF
        j = (j + S[i]) & 0xFF
        S[i], S[j] = S[j], S[i]
        k = S[(S[i] + S[j]) & 0xFF]
        out[n] = data[n] ^ k
    return bytes(out)


def decrypt(data: bytes) -> bytes:
    S = ksa(BYTE_13130)
    return prga(S, data)


if __name__ == "__main__":
    if len(sys.argv) != 3:
        print("Usage: python decrypt_handlestream.py <infile> <outfile>")
        sys.exit(1)

    infile, outfile = sys.argv[1], sys.argv[2]
    enc = open(infile, "rb").read()
    dec = decrypt(enc)
    open(outfile, "wb").write(dec)
    print(f"Decrypted {len(enc)} bytes → {outfile}")