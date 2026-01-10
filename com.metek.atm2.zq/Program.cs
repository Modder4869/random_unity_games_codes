using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

class Program
{
    static void Main()
    {
        var data = File.ReadAllBytes(@"D:\Users\ASUS\Downloads\IDA9.0\2b7e4bb45b52e2eaf40a93f94c305738.bundle");
        var enc_len = BitConverter.ToInt32(data, 0);
        Console.WriteLine("Encrypted length: " + enc_len);

        var encData = new byte[enc_len];
        Buffer.BlockCopy(data, 4, encData, 0, enc_len);
        var a = new byte[32];
        byte[] aesKeyBytes = new byte[16]
        {
    0x12, 0x34, 0x56, 0x78,
    0x90, 0xAB, 0xCD, 0xEF,
    0x12, 0x34, 0x56, 0x78,
    0x90, 0xAB, 0xCD, 0xEF
        };

        string aesKeyStr = Encoding.UTF8.GetString(aesKeyBytes);

        Console.WriteLine("AES key string: " + aesKeyStr);
        var key = Encoding.UTF8.GetBytes("fdsf2HD8S4sh8h9jJK".PadRight(32));
        var iv = Encoding.UTF8.GetBytes(aesKeyStr.PadRight(16)).AsSpan(0, 16).ToArray();

        ////byte[] key =
        ////byte[] iv = 

        try
        {
            var decrypted = DecryptAes(encData, key, iv);

            File.WriteAllBytes("2b7e4bb45b52e2eaf40a93f94c305738_decrypted.bin", decrypted);
            Console.WriteLine("Decrypted output written to 2b7e4bb45b52e2eaf40a93f94c305738_decrypted.bin");
            var _remainingDataFileStart = decrypted.Length + 4;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Decryption failed: " + ex.Message);
        }
    }

    static byte[] DecryptAes(byte[] cipherData, byte[] key, byte[] iv)
    {
        using (var aes = Aes.Create())
        {
            aes.Key = key;
            aes.IV = iv;
            aes.Mode = CipherMode.CBC;   // check actual mode!
            aes.Padding = PaddingMode.PKCS7;

            using var decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
            using var msIn = new MemoryStream(cipherData);
            using var cs = new CryptoStream(msIn, decryptor, CryptoStreamMode.Read);
            using var msOut = new MemoryStream();
            cs.CopyTo(msOut);
            return msOut.ToArray();
        }
    }
}
