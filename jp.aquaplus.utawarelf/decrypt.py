import base64
import json
from Crypto.Cipher import AES
FIXED_KEY = "u/yObiZg1NcuvW5b8XZ53+ml"
FIXED_IV = b'C1/krxDVXslQ7Hj/'

def decrypt_aes_cbc(ciphertext_b64: str, key_str: str) -> str:
    """Decrypt Base64 ciphertext with AES-256-CBC, zero-padded key, PKCS7 padding."""
    ciphertext = base64.b64decode(ciphertext_b64)
    key_bytes = key_str.encode('utf-8')
    if len(key_bytes) < 32:
        key_bytes += b'\x00' * (32 - len(key_bytes))
    else:
        key_bytes = key_bytes[:32]
    cipher = AES.new(key_bytes, AES.MODE_CBC, FIXED_IV)
    decrypted = cipher.decrypt(ciphertext)
    pad_len = decrypted[-1]
    if pad_len < 1 or pad_len > 16:
        raise ValueError("Invalid padding")
    return decrypted[:-pad_len].decode('utf-8').strip()

def decrypt_resource_response_from_file(file_path: str) -> dict:
    """Read JSON file, extract 'body', double-decrypt, return final JSON."""
    with open(file_path, 'r', encoding='utf-8') as f:
        data = json.load(f)
    encrypted_body = data.get('body')
    print(encrypted_body[:16])
    if not encrypted_body:
        raise ValueError("JSON missing 'body' field")
    final_json_str = decrypt_aes_cbc(encrypted_body, FIXED_KEY)
    return json.loads(final_json_str)

if __name__ == "__main__":
    import sys
    if len(sys.argv) != 2:
        print("Usage: python decrypt_resource.py <response.json>")
        sys.exit(1)
    result = decrypt_resource_response_from_file(sys.argv[1])
    print(json.dumps(result, indent=2, ensure_ascii=False))