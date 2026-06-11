#!/usr/bin/env python3
"""
Decrypt packed ARM64 ELF sections — COMPLETE algorithm.

Confirmed by Frida dump comparison (100% match on ALL 3 sections).

Algorithm (mode=1, large sections >1MB):
  1. Skip page header: skip = 0x2000 - (vaddr & 0xFFF)
  2. AES-128-CBC decrypt first 0x4000 bytes (8 blocks x 0x800, each with fresh IV)
  3. Bytes 0x4000 to 0x10000 are PLAINTEXT (never encrypted)
  4. From offset 0x10000 onward: XOR 0xEC on 0x4000 bytes per 0x10000 page
     (sub_155568 XORs 0x4000 bytes at the start of each 0x10000-aligned page)
  5. Remainder bytes after the last full page are also XOR 0xEC

Key derivation:
  - AES key: ASCII string "%08x%08x" (16 bytes, NOT hex-decoded)
  - IV: 02 03 04 05 06 07 08 09 0a 0b 0c 0d 0e 0f 10 11 (fresh per 0x800 block)
  - XOR key: (section_id >> 16) & 0xFF (or 0x87 if zero)

sub_155568 behavior:
  - Takes a1 = section_start + skip + 0x10000
  - XORs 0x4000 bytes at a1 + i*0x10000 for i = 0, 1, 2, ...
  - Then XORs remaining bytes byte-by-byte
  - When extra=0 (our case), no shuffle, just straight XOR
"""

import sys, os, argparse

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
        description="Decrypt packed ARM64 ELF (confirmed algorithm)"
    )
    p.add_argument("binary", help="Path to the packed .so binary")
    p.add_argument(
        "--section-id",
        type=lambda x: int(x, 0),
        default=0xD8EC5BEE,
        help="Section ID / key (default: 0xD8EC5BEE)",
    )
    p.add_argument("--output", help="Output path (default: <binary>_decrypted.so)")
    return p.parse_args()


def page_skip_for_vaddr(vaddr):
    """Calculate actual page skip: 0x2000 - (vaddr & 0xFFF)."""
    return 0x2000 - (vaddr & 0xFFF)


def decrypt_section(data, section_id, vaddr):
    """
    Decrypt a section using the complete algorithm confirmed by Frida comparison.

    Algorithm:
      1. Skip page header (0x2000 - (vaddr & 0xFFF))
      2. AES-128-CBC decrypt first 0x4000 bytes (8 blocks x 0x800, each with fresh IV)
      3. Bytes 0x4000..0x10000 are PLAINTEXT
      4. From 0x10000: XOR 0xEC on 0x4000 bytes per 0x10000 page
      5. Remainder bytes after last full page: XOR 0xEC byte-by-byte

    Confirmed 100% match on .rodata, .text, and il2cpp sections.
    """
    aes_key = ("%08x%08x" % (section_id, section_id)).encode("ascii")[:16]

    iv = bytes(
        [
            0x02,
            0x03,
            0x04,
            0x05,
            0x06,
            0x07,
            0x08,
            0x09,
            0x0A,
            0x0B,
            0x0C,
            0x0D,
            0x0E,
            0x0F,
            0x10,
            0x11,
        ]
    )

    xor_key = (section_id >> 16) & 0xFF
    if xor_key == 0:
        xor_key = 0x87

    result = bytearray(data)
    skip = page_skip_for_vaddr(vaddr)
    section_size = len(data)

    # Step 1: AES-128-CBC decrypt first 0x4000 bytes (8 blocks x 0x800)
    # Each block gets fresh IV (sub_13D260 calls aes_crypt per block)
    for blk_off in range(0, 0x4000, 0x800):
        actual_off = skip + blk_off
        if actual_off + 0x800 <= section_size:
            block = bytes(result[actual_off : actual_off + 0x800])
            cipher = AES.new(aes_key, AES.MODE_CBC, iv=iv)
            result[actual_off : actual_off + 0x800] = cipher.decrypt(block)

    # Step 2: XOR 0x4000 bytes per 0x10000 page (sub_155568 behavior)
    # sub_155568 is called with a1 = skip+0x10000, and XORs 0x4000 bytes
    # at the start of each 0x10000-aligned page from a1
    xored_start = skip + 0x10000
    if xored_start < section_size:
        remaining = section_size - xored_start
        page_off = 0
        while remaining >= (page_off + 0x10000):
            xor_pos = xored_start + page_off
            for i in range(0x4000):
                result[xor_pos + i] ^= xor_key
            page_off += 0x10000

        # Remainder bytes after last full page
        rem_start = xored_start + page_off
        rem_size = remaining - page_off
        for i in range(rem_size):
            result[rem_start + i] ^= xor_key

    return bytes(result)


def hexdump(data, offset=0, length=0x80):
    for i in range(offset, min(offset + length, len(data)), 16):
        chunk = data[i : i + 16]
        hex_part = " ".join(f"{b:02x}" for b in chunk)
        ascii_part = "".join(chr(b) if 32 <= b < 127 else "." for b in chunk)
        print(f"  {i:08x}  {hex_part}  {ascii_part}")


def main():
    args = parse_args()

    with open(args.binary, "rb") as f:
        data = bytearray(f.read())

    with open(args.binary, "rb") as f:
        elf = ELFFile(f)

        print(f"Binary:  {args.binary} ({len(data) / 1048576:.1f} MB)")
        print(f"Key:     0x{args.section_id:08X}")
        print(f"AES key: {('%08x%08x' % (args.section_id, args.section_id))[:16]}")
        print(f"XOR key: 0x{(args.section_id >> 16) & 0xFF:02X}")
        print()

        TARGET_SECS = {".rodata", ".text", "il2cpp"}
        found = []

        for section in elf.iter_sections():
            if section.name in TARGET_SECS:
                found.append(
                    {
                        "name": section.name,
                        "file_offset": section["sh_offset"],
                        "vaddr": section["sh_addr"],
                        "size": section["sh_size"],
                    }
                )

    if not found:
        sys.exit("No encrypted sections found (.rodata, .text, il2cpp)")

    print(
        f"{'Section':<12} {'File Offset':>12} {'Vaddr':>12} {'Size':>12} {'Skip':>8} {'MB':>8}"
    )
    print("-" * 72)
    for s in found:
        skip = page_skip_for_vaddr(s["vaddr"])
        print(
            f"{s['name']:<12} 0x{s['file_offset']:08X}   0x{s['vaddr']:08X}   0x{s['size']:08X}   0x{skip:04X}   {s['size'] / 1048576:.1f}"
        )
    print()

    for s in found:
        foff, size, vaddr = s["file_offset"], s["size"], s["vaddr"]
        skip = page_skip_for_vaddr(vaddr)
        print(
            f"Decrypting {s['name']} (page_skip=0x{skip:04X}, vaddr=0x{vaddr:08X})..."
        )
        print(
            f"  Original: offset=0x{foff:08X}, size=0x{size:08X} ({size / 1048576:.1f} MB)"
        )

        # Show what we're decrypting
        print(
            f"  Will decrypt: AES-CBC (first 0x4000) + XOR (0x4000/page from 0x10000)"
        )
        print(f"  XOR key: 0x{(args.section_id >> 16) & 0xFF:02X}")

        section_data = bytes(data[foff : foff + size])
        
        data[foff : foff + size] = decrypt_section(section_data, args.section_id, vaddr)

        # Show decrypted AES region preview
        aes_start = foff + skip
        aes_end = min(aes_start + 0x800, foff + size)
        dec = data[aes_start:aes_end]
        print(f"  Decrypted AES preview (first 0x800 bytes after skip):")
        hexdump(bytes(dec), offset=0)

        # Show XOR region preview
        if size > 0x10000 + skip:
            xor_start = foff + skip + 0x10000
            xor_end = min(xor_start + 0x80, foff + size)
            xor_region = data[xor_start:xor_end]
            print(f"  XOR region preview (offset 0x10000 after skip):")
            print(f"xor start {xor_start} {xor_region[:256].hex()}")
            hexdump(bytes(xor_region), offset=0)
        print()

    out = args.output or os.path.splitext(args.binary)[0] + "_decrypted.so"
    with open(out, "wb") as f:
        f.write(data)
    print(f"Written: {out} ({len(data) / 1048576:.1f} MB)")


if __name__ == "__main__":
    main()
