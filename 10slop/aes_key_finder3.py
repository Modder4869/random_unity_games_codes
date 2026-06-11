#!/usr/bin/env python3
"""
Fully corrected parallel scanner.
- Decrypts full ciphertext once per candidate
- Capstone created inside worker (pickle-safe)
- Prints when the known good section_id 0xD8EC5BEE is encountered
"""

import sys
import io
import argparse
from multiprocessing import Pool, cpu_count
from Crypto.Cipher import AES
from elftools.elf.elffile import ELFFile
from capstone import Cs, CS_ARCH_ARM64, CS_MODE_ARM
from tqdm import tqdm

# ------------------------------------------------------------
def page_skip(vaddr):
    return 0x2000 - (vaddr & 0xFFF)
def extract_nibbles(a4):
    return [(a4 >> (28 - i * 4)) & 0xF for i in range(8)]
def extract_xor_blocks(data, start_offset, max_bytes, a4=0):
    blocks     = []
    page_size  = 0x10000
    xor_block  = 0x4000
    collected  = 0

    if a4 == 0:
        pos = start_offset
        while collected < max_bytes:
            take  = min(xor_block, max_bytes - collected)
            block = data[pos:pos + take]
            if not block:
                break
            blocks.append(block)
            collected += len(block)
            pos += page_size
    else:
        # Build inverse permutation — same as decrypt_section
        nibbles = extract_nibbles(a4)
        inv     = [0] * 8
        for i, n in enumerate(nibbles):
            inv[n] = i

        group_base = start_offset
        remaining  = len(data) - start_offset

        while collected < max_bytes and remaining >= 0x20000:
            # For each output slot dest_i, read from staging position inv[dest_i]
            # staging position k is at group_base + k * page_size
            for dest_i in range(8):
                if collected >= max_bytes:
                    break
                src_off = group_base + inv[dest_i] * page_size
                take    = min(xor_block, max_bytes - collected)
                block   = data[src_off:src_off + take]
                if not block:
                    break
                blocks.append(block)
                collected += len(block)

            group_base += 0x80000  # 8 * 0x10000, same as decrypt_section
            remaining  -= 0x80000

    return b''.join(blocks)

def score_plaintext(data):
    if not data:
        return -1
    score = 0
    for b in data:
        if 32 <= b <= 126:
            score += 2
        elif b == 0:
            score += 1
        elif b in (9,10,13):
            score += 1
        else:
            score -= 2
    return score

def brute_xor_key(section_data, section_vaddr, max_bytes=0x10000, a4=0):
    skip      = page_skip(section_vaddr)
    xor_start = skip + 0x10000
    if xor_start >= len(section_data):
        return None, None

    ciphertext = extract_xor_blocks(section_data, xor_start, max_bytes, a4)
    print("cipher xor",ciphertext[:256].hex())
    if len(ciphertext) < 64:
        return None, None

    best_key   = None
    best_score = -1
    for k in range(256):
        dec = bytes(b ^ k for b in ciphertext)
        s   = score_plaintext(dec)
        if s > best_score:
            best_score = s
            best_key   = k

    return best_key, best_score

def cheap_instruction_count(data):
    if len(data) < 4:
        return 0
    cnt = 0
    for i in range(0, len(data) - 3, 4):
        w = int.from_bytes(data[i:i+4], 'little')
        if w != 0 and w != 0xFFFFFFFF:
            cnt += 1
    return cnt

def real_instruction_count(data, md):
    cnt = 0
    try:
        for _ in md.disasm_lite(data, 0x1000):
            cnt += 1
    except:
        pass
    return cnt

def check_range(args):
    start, end, xor_key, ciphertext, iv, aes_bytes, threshold = args
    # Create Capstone object inside worker (pickle-safe)
    md = Cs(CS_ARCH_ARM64, CS_MODE_ARM)
    md.detail = False

    known_byte = xor_key & 0xFF
    for idx in range(start, end):
        high = (idx >> 16) & 0xFF
        mid_low = (idx >> 8) & 0xFF
        low = idx & 0xFF
        sid = (high << 24) | (known_byte << 16) | (mid_low << 8) | low

        # # Log when we hit the known good candidate (0xD8EC5BEE)
        # if sid == 0xD8EC5BEE:
        #     print(f"\n[WORKER] Found candidate 0xD8EC5BEE at index {idx}, evaluating...")

        key_str = ("%08x%08x" % (sid, sid))[:16].encode('ascii')
        plain = AES.new(key_str, AES.MODE_CBC, iv=iv).decrypt(ciphertext)

        # Cheap filter on first 16 bytes
        if cheap_instruction_count(plain[:16]) < 2:
            continue
        # Full cheap filter
        if cheap_instruction_count(plain) < threshold:
            continue
        # Final Capstone validation
        real_cnt = real_instruction_count(plain, md)
        if real_cnt >= threshold:
            return (idx, sid)
    return None

def find_key_parallel(binary_path, aes_section_name, xor_key, aes_bytes,
                      start_index, end_index, threshold=8, jobs=None, chunk_size=4096):
    with open(binary_path, "rb") as f:
        raw = f.read()
    elf = ELFFile(io.BytesIO(raw))
    target = next((s for s in elf.iter_sections() if s.name == aes_section_name), None)
    if not target:
        print(f"Section {aes_section_name} not found")
        return None, None

    skip = page_skip(target["sh_addr"])
    aes_start = skip
    if aes_start + aes_bytes > target["sh_size"]:
        aes_bytes = target["sh_size"] - aes_start
        aes_bytes = (aes_bytes // 16) * 16
        if aes_bytes < 16:
            print("Not enough data")
            return None, None

    ciphertext = raw[target["sh_offset"]+aes_start : target["sh_offset"]+aes_start+aes_bytes]
    iv = bytes([0x02,0x03,0x04,0x05,0x06,0x07,0x08,0x09,
                0x0A,0x0B,0x0C,0x0D,0x0E,0x0F,0x10,0x11])

    total_candidates = end_index - start_index
    max_instructions = aes_bytes // 4
    if threshold > max_instructions:
        print(f"Warning: threshold {threshold} > max instructions ({max_instructions}). Lowering to {max_instructions}.")
        threshold = max_instructions

    print(f"Scanning {total_candidates:,} indices ({start_index} to {end_index-1})")
    print(f"Threshold: {threshold} / {max_instructions} valid instructions")
    print(f"Ciphertext size: {aes_bytes} bytes")

    if jobs is None:
        jobs = cpu_count()
    # Build chunks WITHOUT md (will be created inside worker)
    chunks = [(s, min(s+chunk_size, end_index), xor_key, ciphertext, iv, aes_bytes, threshold)
              for s in range(start_index, end_index, chunk_size)]

    print(f"Using {jobs} CPU cores, {len(chunks)} work chunks (each up to {chunk_size} candidates)")

    with Pool(jobs) as pool:
        results = pool.imap_unordered(check_range, chunks)
        with tqdm(total=len(chunks), desc="Chunks processed", unit="chunk") as pbar:
            for res in results:
                pbar.update(1)
                if res is not None:
                    pool.terminate()
                    idx, sid = res
                    print(f"\n✅ Found! Index: {idx} (0x{idx:06X})  section_id: 0x{sid:08X}")
                    return sid, idx
    print("❌ No candidate reached the threshold")
    return None, None

def test_single_key(binary_path, aes_section_name, xor_key, aes_bytes, test_sid):
    with open(binary_path, "rb") as f:
        raw = f.read()
    elf = ELFFile(io.BytesIO(raw))
    target = next((s for s in elf.iter_sections() if s.name == aes_section_name), None)
    if not target:
        print(f"Section {aes_section_name} not found")
        return

    skip = page_skip(target["sh_addr"])
    aes_start = skip
    if aes_start + aes_bytes > target["sh_size"]:
        aes_bytes = target["sh_size"] - aes_start
        aes_bytes = (aes_bytes // 16) * 16
        if aes_bytes < 16:
            print("Not enough data")
            return

    ciphertext = raw[target["sh_offset"]+aes_start : target["sh_offset"]+aes_start+aes_bytes]
    iv = bytes([0x02,0x03,0x04,0x05,0x06,0x07,0x08,0x09,
                0x0A,0x0B,0x0C,0x0D,0x0E,0x0F,0x10,0x11])

    key_str = ("%08x%08x" % (test_sid, test_sid))[:16].encode('ascii')
    plain = AES.new(key_str, AES.MODE_CBC, iv=iv).decrypt(ciphertext)

    md = Cs(CS_ARCH_ARM64, CS_MODE_ARM)
    md.detail = False
    cheap = cheap_instruction_count(plain)
    real = real_instruction_count(plain, md)

    print(f"Section ID: 0x{test_sid:08X}")
    print(f"Cheap instruction count: {cheap} / {aes_bytes//4}")
    print(f"Real (Capstone) instruction count: {real} / {aes_bytes//4}")
    print(f"First 32 bytes: {plain[:32].hex()}")
    print("Disassembly of first 32 bytes:")
    for insn in md.disasm_lite(plain[:32], 0x1000):
        print(f"  {insn[0]:x}: {insn[2]} {insn[3]}")

def main():
    parser = argparse.ArgumentParser()
    parser.add_argument("binary")
    parser.add_argument("--xor-section", default=".rodata")
    parser.add_argument("--aes-section", default=".text")
    parser.add_argument("--xor-max-bytes", type=int, default=0x10000)
    parser.add_argument("--aes-bytes", type=int, default=128)
    parser.add_argument("--start-index", type=int, help="Required for scanning")
    parser.add_argument("--end-index", type=int)
    parser.add_argument("--max-candidates", type=int)
    parser.add_argument("--threshold", type=int, default=8)
    parser.add_argument("--jobs", type=int, default=None)
    parser.add_argument("--chunk-size", type=int, default=4096)
    parser.add_argument("--test-key", type=lambda x: int(x,0), help="Test a single section_id")
    parser.add_argument("--a4", type=lambda x: int(x, 0), default=0,
                    help="Shuffle key (default: 0 = no shuffle)")
    args = parser.parse_args()

    # Find XOR key
    with open(args.binary, "rb") as f:
        raw = f.read()
    elf = ELFFile(io.BytesIO(raw))
    xor_sec = next((s for s in elf.iter_sections() if s.name == args.xor_section), None)
    if not xor_sec:
        sys.exit(f"Section {args.xor_section} not found")
    print(f"Finding XOR key from {args.xor_section}...")
    sec_data = raw[xor_sec["sh_offset"]:xor_sec["sh_offset"]+xor_sec["sh_size"]]
    xor_key, _ = brute_xor_key(sec_data, xor_sec["sh_addr"], args.xor_max_bytes, args.a4)
    if xor_key is None:
        sys.exit("XOR key not found")
    print(f"XOR key = 0x{xor_key:02X}")

    if args.test_key is not None:
        test_single_key(args.binary, args.aes_section, xor_key, args.aes_bytes, args.test_key)
        return

    if args.start_index is None:
        sys.exit("Either provide --test-key or --start-index for scanning")

    total = 256*256*256
    start = args.start_index
    if args.max_candidates:
        end = min(start + args.max_candidates, total)
    elif args.end_index is not None:
        end = min(args.end_index, total)
    else:
        end = total

    sid, idx = find_key_parallel(args.binary, args.aes_section, xor_key, args.aes_bytes,
                                 start, end, args.threshold, args.jobs, args.chunk_size)
    if sid:
        print(f"\n🎉 Success! Use section_id 0x{sid:08X} (index {idx})")

if __name__ == "__main__":
    main()