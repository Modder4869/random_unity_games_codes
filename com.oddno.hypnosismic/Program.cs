using System.Security.Cryptography;
using System.Text;

public class Program
{
    public static string Decrypt(string text, byte[] salt, byte[] password)
    {
        var s = Encoding.UTF8.GetBytes(Convert.ToBase64String(salt, 0, salt.Length));
        var k = Encoding.UTF8.GetBytes(Convert.ToBase64String(password, 0, password.Length));

        byte[] key = k;
        byte[] iv = s;
        byte[] buffer = Convert.FromBase64String(text);
        using (var memoryStream = new MemoryStream(buffer))
        using (var aes = Aes.Create())
        {
            aes.Key = key;
            aes.IV = iv;
            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.PKCS7;
            using (var cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Read))
            using (var reader = new StreamReader(cryptoStream, Encoding.UTF8))
            {
                return reader.ReadToEnd();
            }
        }
    }
    public static void Main()
    {
        try
        {
            byte[] InitializeData1 = new byte[12]{
    0xCC, 0xB6, 0xA3, 0x1B, 0xBF, 0x39, 0xE0, 0x99, 0x9F, 0x71, 0x98, 0x9D
};
            //------------------------------------------------------------
            byte[] InitializeData2 = new byte[24]{
     0x50, 0x7C, 0xCC, 0x26, 0x31, 0x7C, 0x47, 0x89, 0x3A, 0x46, 0x6E, 0x9B, 0xE9, 0x78, 0xE1, 0x49,
    0x36, 0xEB, 0x5C, 0xC6, 0xBB, 0xE9, 0x20, 0x60
};          var InitializeData3 = "v+GjNxoxG9XN1aZkP33buw==";

            var result =  Decrypt(InitializeData3, InitializeData1, InitializeData2);
            Console.WriteLine("Decrypted text: " + result);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Decryption failed: " + ex.Message);
        }
    }
}