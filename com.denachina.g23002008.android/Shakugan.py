import os
import sys

MAX_CODE_LEN = 10  # Maximum length of the encodebuf array
KEY = 95  # Hardcoded key value

def deCode(encodebuf, key):
    if encodebuf is None:
        print("EncryptionCode:: enCode / deCode error!!!")
        return None
    
    for i in range(min(len(encodebuf), MAX_CODE_LEN)):
        b = encodebuf[i] ^ (key & 0xFF)
        encodebuf[i] = b
    
    return encodebuf

def decode_files(input_folder, output_folder):
    # Create the output folder if it doesn't exist
    os.makedirs(output_folder, exist_ok=True)

    # Recursively search for files with ".3d" extension
    for root, _, files in os.walk(input_folder):
        for file_name in files:
            # print(file_name)
            if file_name.endswith('.u3d'):
                input_file_path = os.path.join(root, file_name)
                output_file_path = os.path.join(output_folder, os.path.relpath(input_file_path, input_folder))
                os.makedirs(os.path.dirname(output_file_path), exist_ok=True)
                # Read the file contents
                with open(input_file_path, 'rb') as file:
                    file_contents = bytearray(file.read())

                # Apply the deCode function to the file contents
                decoded_contents = deCode(file_contents, KEY)

                # Write the decoded contents to the output file
                with open(output_file_path, 'wb') as output_file:
                    output_file.write(decoded_contents)

                print("Decoded content written to the output file:", output_file_path)


if __name__ == "__main__":
    # Check if all command-line arguments are provided
    if len(sys.argv) < 3:
        print("Usage: python script.py <input_folder> <output_folder>")
        sys.exit(1)
    
    input_folder = sys.argv[1]
    output_folder = sys.argv[2]

    decode_files(input_folder, output_folder)
