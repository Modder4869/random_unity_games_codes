BYTE_13130_HEX = (
    "4bd45de66ff8810a931ca52eb740c930db646876ff88119a23ac35be47d059e26bf47d066f18a12ab33cc54ed7603172"
    "fb320d966fa8317843cc55de4c73790244149d263138c14ad35ce56ef78009921ba42db63fc851da63ec75fe873899594"
    "7344246cf58e157f37c058e4ea0294b3bc44dd65fe871fa830c951ea730b942cb543166ef78018a429c6aae4cc049d25b"
    "e46d427f75911aa32c773ec750d962eb74fd86369821aa69bc6ace38e069f27b398d169f28b13a534cd55ee77078820b4"
    "a1d382f4e41ca536e6573770089129b59ad69bf48d15ae36cf57e079070a22b363dc64fd8616e73fc850e9720a932bb44"
    "cd56df73f17a038c159e27b031c2"
)

# Convert reference hex to bytes
ref_bytes = bytes.fromhex(BYTE_13130_HEX)

# Generate using your implementation (imported or inline)
def generate_byte_13130():
    dword_2334 = [
        0x9A, 0x95, 0xBE, 0x2E, 0xD3, 0xCB, 0x0F, 0x3C, 0xC9,
        0x60, 0xE1, 0xF5, 0xC3, 0x93, 0x34, 0x44, 0x5F, 0x8A,
        0x8C, 0x82, 0x5D, 0x62, 0xA4, 0xD3, 0xA8, 0xAA, 0x37,
        0xDE, 0x3D, 0xC5, 0xB8, 0xC1, 0xD1, 0x67, 0x6C, 0xB1,
        0xA4, 0x88, 0xAC, 0x31, 0x6F, 0xA8, 0x24, 0x3D, 0x12,
        0x44, 0x6F, 0x40, 0xE7, 0xFE
    ][:50]

    patch_str = b"wux1js0LnG6s8BoaYjL18BQisjxpKNSJYWN96B82Niosh1KDn1"
    byte_13130 = [0] * 256

    v = [0x0E, 0x0C, 0x0A, 0x08, 0x06, 0x04, 0x02, 0x00]
    v10 = 0x4B
    v11 = 0x10
    n256 = 0

    while n256 < 256:
        block = []
        for vi in v[::-1]:
            for k in range(2):
                val = 0x85 * vi + (vi << 2) + v10
                block.append(val & 0xFF)
                vi += 1
        for j in range(16):
            byte_13130[n256 + j] = block[j % len(block)]
        n256 += 16
        v = [x + v11 for x in v]

    for i in range(50):
        byte_13130[dword_2334[i]] = patch_str[i]

    return bytes(byte_13130)

# Generate
gen_bytes = generate_byte_13130()

# Compare
if gen_bytes == ref_bytes:
    print("✅ byte_13130 matches reference!")
else:
    print("❌ Mismatch! First difference at offset:",
          next(i for i, (a, b) in enumerate(zip(gen_bytes, ref_bytes)) if a != b))
