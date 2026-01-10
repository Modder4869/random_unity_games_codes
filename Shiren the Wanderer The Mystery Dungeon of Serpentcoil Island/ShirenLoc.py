import hashlib
from Crypto.Cipher import AES
import gzip
import msgpack
import json

def generate_aes_key(key_string):
    return hashlib.sha256(key_string.encode()).digest()

def aes_decrypt(file_path, key):
    with open(file_path, 'rb') as f:
        iv = f.read(16) 
        ciphertext = f.read()
    cipher = AES.new(key, AES.MODE_CBC, iv)
    decrypted = cipher.decrypt(ciphertext)

    decrypted = unpad(decrypted)
    return decrypted

def unpad(data):
    """Remove PKCS7 padding."""
    padding_length = data[-1]
    return data[:-padding_length]

class CustomJSONEncoder(json.JSONEncoder):
    def default(self, obj):
        if isinstance(obj, bytes):
            xor_result = bytes(byte ^ 0xFF for byte in obj)
            return xor_result.decode('utf-8')

def main():
    file_path = r'd9b80652efe2084eedfcdf1c0841cd76d77e6ae3' 
    # file_path = r'D:\Users\ASUS\Downloads\IDA9.0\4d60762622c8739989661a9419f70fc78f9b7885
    key_string = 'cLRzSgBxoP47Yntz'
    aes_key = generate_aes_key(key_string)
    decrypted_data = aes_decrypt(file_path, aes_key)

    try:
        decompressed_data = gzip.decompress(decrypted_data)
        print("Successfully decompressed data.")
    except OSError as e:
        print("Error during decompression:", e)
        return

    message_pack_data = msgpack.unpackb(decompressed_data)
    output_file = "Shiren_output.json"
 
    all_objects = []
    for obj in message_pack_data:
        obj_json = json.dumps(obj, cls=CustomJSONEncoder)  
        all_objects.append(json.loads(obj_json))

    with open(output_file, "w", encoding='utf-8') as json_file:
        json.dump(all_objects, json_file, indent=2, ensure_ascii=False)

    print(f"Data written to {output_file}")

if __name__ == "__main__":
    main()
