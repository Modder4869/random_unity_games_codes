def generate_key(seed: int):
    keys = []
    for _ in range(256):
        seed = (0x0BB38435 * seed + 0x3619636B) & 0xFFFFFFFF
        byte = (seed >> 9) & 0xFF
        keys.append(byte)
    return keys

def print_key_hex(seed: int):
    key = generate_key(seed)
    hex_string = ''.join(f'{b:02x}' for b in key)
    print(hex_string)
print_key_hex(0x2D6D4D69 )