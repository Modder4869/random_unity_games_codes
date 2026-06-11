#!/usr/bin/env python3
"""
Decrypt packed ARM64 ELF sections — COMPLETE algorithm with shuffle.

Algorithm (mode=1, large sections >1MB):
  1. Skip page header: skip = 0x2000 - (vaddr & 0xFFF)
  2. AES-128-CBC decrypt first 0x4000 bytes (8 blocks x 0x800, each with fresh IV)
  3. Bytes 0x4000 to 0x10000 are PLAINTEXT (never encrypted)
  4. From offset 0x10000 onward: XOR key on 0x4000 bytes per 0x10000 page
  5. If a4 != 0: every 8 chunks, scatter them using nibbles of a4 as dest indices
  6. Remainder bytes after the last full page are also XOR'd

Key derivation:
  - AES key: ASCII string "%08x%08x" (16 bytes, NOT hex-decoded)
  - IV: 02 03 04 05 06 07 08 09 0a 0b 0c 0d 0e 0f 10 11 (fresh per 0x800 block)
  - XOR key: (section_id >> 16) & 0xFF (or 0x87 if zero)

Shuffle (when a4 != 0):
  - Extract 8 nibbles from a4 MSN→LSN: [(a4 >> (28 - i*4)) & 0xF for i in range(8)]
  - Every 8 XOR'd chunks (8 x 0x4000 = 0x20000), scatter each chunk to
    base + nibble[i] * 0x10000, where base = start of current 8-page group
"""

import sys
import os
import argparse

try:
    from elftools.elf.elffile import ELFFile
except ImportError:
    sys.exit("Need pyelftools: pip install pyelftools")

try:
    from Crypto.Cipher import AES
except ImportError:
    sys.exit("Need pycryptodome: pip install pycryptodome")


def parse_args():
    p = argparse.ArgumentParser(
        description="Decrypt packed ARM64 ELF (complete algorithm with shuffle)"
    )
    p.add_argument("binary", help="Path to the packed .so binary")
    p.add_argument(
        "--section-id",
        type=lambda x: int(x, 0),
        default=0xD8EC5BEE,
        help="Section ID / key (default: 0xD8EC5BEE)",
    )
    p.add_argument(
        "--a4",
        type=lambda x: int(x, 0),
        default=0,
        help="Shuffle key a4 (default: 0 = no shuffle)",
    )
    p.add_argument(
        "--output",
        help="Output path (default: <binary>_decrypted.so)"
    )
    return p.parse_args()


def page_skip_for_vaddr(vaddr):
    """Calculate actual page skip: 0x2000 - (vaddr & 0xFFF)."""
    return 0x2000 - (vaddr & 0xFFF)


def extract_nibbles(a4):
    """
    Extract 8 nibbles from a4, MSN to LSN.
    Derived from shift tables:
      xmmword_18EBE0 = [-28, -24, -20, -16] (int32 LE)
      xmmword_18ED20 = [-12,  -8,  -4,   0] (int32 LE)
    vshlq_u32 with negative shift = right shift, mask & 0x0F.
    """
    return [(a4 >> (28 - i * 4)) & 0xF for i in range(8)]
def decrypt_section(data, section_id, vaddr, a4=0):
    aes_key = ("%08x%08x" % (section_id, section_id)).encode("ascii")[:16]
    iv = bytes([0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09,
                0x0A, 0x0B, 0x0C, 0x0D, 0x0E, 0x0F, 0x10, 0x11])
    xor_key = (section_id >> 16) & 0xFF
    if xor_key == 0:
        xor_key = 0x87

    result = bytearray(data)
    skip = page_skip_for_vaddr(vaddr)
    section_size = len(data)

    # AES-128-CBC decrypt first 0x4000 bytes (8 blocks x 0x800)
    for blk_off in range(0, 0x4000, 0x800):
        actual_off = skip + blk_off
        if actual_off + 0x800 <= section_size:
            block = bytes(result[actual_off:actual_off + 0x800])
            cipher = AES.new(aes_key, AES.MODE_CBC, iv=iv)
            result[actual_off:actual_off + 0x800] = cipher.decrypt(block)

    xored_start = skip + 0x10000
    if xored_start >= section_size:
        return bytes(result)

    remaining = section_size - xored_start

    if a4 == 0:
        page_off = 0
        while remaining >= (page_off + 0x10000):
            xor_pos = xored_start + page_off
            for i in range(0x4000):
                result[xor_pos + i] ^= xor_key
            page_off += 0x10000
        rem_start = xored_start + page_off
        for i in range(remaining - page_off):
            result[rem_start + i] ^= xor_key

    else:
        # Build inverse permutation of nibbles
        # nibbles[i] = dest slot for staging chunk i (scatter)
        # inv[slot]  = which staging chunk belongs at that slot
        nibbles = extract_nibbles(a4)
        inv     = [0] * 8
        for i, n in enumerate(nibbles):
            inv[n] = i

        staging     = bytearray(0x20000)
        stage_count = 0
        group_base  = xored_start
        page_off    = 0

        while remaining >= (page_off + 0x10000):
            xor_pos = xored_start + page_off

            # 1. XOR 0x4000 bytes in-place
            for i in range(0x4000):
                result[xor_pos + i] ^= xor_key

            # 2. Stage the XOR'd result
            slot = stage_count * 0x4000
            staging[slot:slot + 0x4000] = result[xor_pos:xor_pos + 0x4000]
            stage_count += 1

            if stage_count == 8:
                # Use inverse permutation: slot i gets staging[inv[i]]
                tmp = bytearray(0x20000)
                for dest_i in range(8):
                    src_i     = inv[dest_i]
                    tmp[dest_i * 0x4000:(dest_i + 1) * 0x4000] = \
                        staging[src_i * 0x4000:(src_i + 1) * 0x4000]

                for dest_i in range(8):
                    dest_off = group_base + dest_i * 0x10000
                    if dest_off + 0x4000 <= section_size:
                        result[dest_off:dest_off + 0x4000] = \
                            tmp[dest_i * 0x4000:(dest_i + 1) * 0x4000]

                staging     = bytearray(0x20000)
                stage_count = 0
                group_base += 0x80000

            page_off += 0x10000

        # Tail bytes
        rem_start = xored_start + page_off
        for i in range(remaining - page_off):
            result[rem_start + i] ^= xor_key

    return bytes(result)
def hexdump(data, offset=0, length=0x80):
    for i in range(offset, min(offset + length, len(data)), 16):
        chunk = data[i:i + 16]
        hex_part = " ".join(f"{b:02x}" for b in chunk)
        ascii_part = "".join(chr(b) if 32 <= b < 127 else "." for b in chunk)
        print(f"  {i:08x}  {hex_part:<47}  {ascii_part}")


def main():
    args = parse_args()

    with open(args.binary, "rb") as f:
        data = bytearray(f.read())

    with open(args.binary, "rb") as f:
        elf = ELFFile(f)

        print(f"Binary:     {args.binary} ({len(data) / 1048576:.1f} MB)")
        print(f"Section ID: 0x{args.section_id:08X}")
        print(f"AES key:    {('%08x%08x' % (args.section_id, args.section_id))[:16]}")
        print(f"XOR key:    0x{(args.section_id >> 16) & 0xFF:02X}")
        print(f"a4 (shuffle): 0x{args.a4:08X}", end="")
        if args.a4:
            nibs = extract_nibbles(args.a4)
            print(f"  nibbles: {[hex(n) for n in nibs]}")
        else:
            print("  (no shuffle)")
        print()

        TARGET_SECS = {".rodata", ".text", "il2cpp"}
        found = []

        for section in elf.iter_sections():
            if section.name in TARGET_SECS:
                found.append({
                    "name":        section.name,
                    "file_offset": section["sh_offset"],
                    "vaddr":       section["sh_addr"],
                    "size":        section["sh_size"],
                })

    if not found:
        sys.exit("No encrypted sections found (.rodata, .text, il2cpp)")

    print(f"{'Section':<12} {'File Offset':>12} {'Vaddr':>12} "
          f"{'Size':>12} {'Skip':>8} {'MB':>6}")
    print("-" * 72)
    for s in found:
        skip = page_skip_for_vaddr(s["vaddr"])
        print(f"{s['name']:<12} 0x{s['file_offset']:08X}   0x{s['vaddr']:08X}   "
              f"0x{s['size']:08X}   0x{skip:04X}   {s['size'] / 1048576:.1f}")
    print()

    for s in found:
        foff  = s["file_offset"]
        size  = s["size"]
        vaddr = s["vaddr"]
        skip  = page_skip_for_vaddr(vaddr)

        print(f"Decrypting {s['name']} "
              f"(page_skip=0x{skip:04X}, vaddr=0x{vaddr:08X}, "
              f"size=0x{size:08X} / {size / 1048576:.1f} MB)...")

        section_data = bytes(data[foff:foff + size])
        decrypted    = decrypt_section(section_data, args.section_id, vaddr, args.a4)
        data[foff:foff + size] = decrypted

        # AES region preview
        aes_preview_start = skip
        aes_preview_end   = min(aes_preview_start + 0x80, size)
        print(f"  AES region preview (first 0x80 bytes after skip=0x{skip:04X}):")
        hexdump(decrypted, offset=aes_preview_start, length=0x80)

        # XOR region preview
        xor_region_start = skip + 0x10000
        if xor_region_start < size:
            print(f"  XOR region preview (offset 0x{xor_region_start:X}):")
            hexdump(decrypted, offset=xor_region_start, length=0x80)

        print()

    out = args.output or (os.path.splitext(args.binary)[0] + "_decrypted.so")
    with open(out, "wb") as f:
        f.write(data)
    print(f"Written: {out} ({len(data) / 1048576:.1f} MB)")


if __name__ == "__main__":
    main()