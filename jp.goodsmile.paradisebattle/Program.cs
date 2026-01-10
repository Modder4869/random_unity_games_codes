using System.Security.Cryptography;
using System.Text;
public static class Hasher
{
    private const string hashKey =
      "*0h>%iZAAdrw[R5l(S+nEmzLp?|ld5QC.n(r'$l9JhqAYl#Iq+o5xK3'9m^872WbH@uIG0~6&zujCBC;zigI%o..,p2ZkQAO,iLjJjW;um1c}mrCSLPJ6$WwKS$=YX:<";
    private const string hashSalt = "Q?p%y):^p(N;}{5*";
    public static string HashString(string text, int maxLength)
    {
        if (text == null)
            throw new ArgumentNullException(nameof(text));

        byte[] inArray = HashBytes(text, maxLength);

        string result = Convert.ToBase64String(inArray);

        if (maxLength >= 1 && result.Length > maxLength)
        {
            int startIndex = (result.Length - maxLength) / 2;
            result = result.Substring(startIndex, maxLength);
        }

        return result;
    }

    public static string CNV(string key)
    {
        if (key == null)
            throw new ArgumentNullException(nameof(key));

        int newLength = key.Length / 2;
        char[] val = new char[newLength];

        for (int i = 0; i < key.Length; i++)
        {
            if ((i & 1) != 0)
            {
                val[i / 2] = key[i];
            }
        }

        return new string(val);
    }
    private static string GetHashSalt()//Bone::AppCryptoConfig::get_HashSalt
    {

        string salt = CNV(hashSalt);
        return salt;
    }
    private static string GetHashKey()//Bone::AppCryptoConfig::get_HashKey
    {

        string salt = CNV(hashKey);

        return salt;
    }
    private static byte[] HashBytes(string text, int maxLength)
    {
        string salt = GetHashSalt();
        string input = salt + text;

        byte[] inputBytes = Encoding.UTF8.GetBytes(input);
        byte[] keyBytes = Encoding.UTF8.GetBytes(GetHashKey());

        using (var hmac = new HMACSHA256(keyBytes))
        {
            byte[] hash = hmac.ComputeHash(inputBytes);

            if (maxLength >= 1 && hash.Length > maxLength)
            {
                int start = (hash.Length - maxLength) / 2;
                byte[] trimmed = new byte[maxLength];
                Array.Copy(hash, start, trimmed, 0, maxLength);
                return trimmed;
            }

            return hash;
        }
    }
    public static string DecryptKey(string encryptedBase64, string password, string salt)//Bone::AppMsgPackConfig::GetCryptKey
    {
        byte[] all = Convert.FromBase64String(encryptedBase64);
        byte[] iv = new byte[16];
        byte[] cipher = new byte[all.Length - 16];
        Buffer.BlockCopy(all, 0, iv, 0, 16);
        Buffer.BlockCopy(all, 16, cipher, 0, cipher.Length);

        byte[] key = new Rfc2898DeriveBytes(
            password,
            Encoding.UTF8.GetBytes(salt),
            1000,
            HashAlgorithmName.SHA256
        ).GetBytes(32);

        using var aes = Aes.Create();
        aes.KeySize = 256;
        aes.Key = key;
        aes.IV = iv;
        aes.Mode = CipherMode.CBC;
        aes.Padding = PaddingMode.PKCS7;

        using var dec = aes.CreateDecryptor();
        byte[] plain = dec.TransformFinalBlock(cipher, 0, cipher.Length);
        return Encoding.UTF8.GetString(plain);
    }
    static class AppCryptoConfig
    {

    }
    static void Main()
    {
        string result = DecryptKey(
            "mmMZG+88jRluvy4mseAm7Y+3mO8L+XQw5YRYact7iqDOmq7UIrQdaX8klwV9JImx",
            "U8eWzTzJr5aXp9C",
            "vXz45Yq6wKvn4h3qL"
        );
        Console.WriteLine(HashString(result, 16));
        //  Console.WriteLine("final " + "OLhUoUOgMnmfUar9");
    }

}
