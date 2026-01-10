using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace EncryptUtilClone
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "f48c40c4fef4";

            byte[] aad = EncryptUtil.BuildAAD();
            byte[] salt = EncryptUtil.MakeFixedSalt();
            byte[] key = EncryptUtil.Derive(password);

            Console.WriteLine("AAD        : " + Hex(aad));
            Console.WriteLine("Salt (16)  : " + Hex(salt));
            Console.WriteLine("Key  (32)  : " + Hex(key));
            var path = @"DataPvpWeaponEffect";
             byte[] encrypted = File.ReadAllBytes(path);
            byte[] plain = EncryptUtil.Decrypt(encrypted, key);
            File.WriteAllBytes(path+"dec", plain);
        }

        static string Hex(byte[] b) => BitConverter.ToString(b).Replace("-", "");
    }

    public static class EncryptUtil
    {
        public static byte[] BuildAAD()
        {
            byte[] aad = new byte[5];
            using (var ms = new MemoryStream(aad))
            using (var bw = new BinaryWriter(ms))
            {
                bw.Write(0x524C545A); // Z L T R
                bw.Write((byte)0x31); // '1'
            }
            return aad;
        }
        public static byte[] MakeFixedSalt()
        {
            using var sha = SHA256.Create();
            byte[] aad = BuildAAD();
            byte[] hash = sha.ComputeHash(aad);

            byte[] salt = new byte[16];
            Buffer.BlockCopy(hash, 0, salt, 0, 16);
            return salt;
        }
        public static byte[] Derive(string password)
        {
            byte[] salt = MakeFixedSalt();
            using var kdf = new Rfc2898DeriveBytes(
                password,
                salt,
                60000,
                HashAlgorithmName.SHA256);

            return kdf.GetBytes(32);
        }

        public static byte[] DeriveKey(byte[] projectKey, byte[] salt)
        {
            byte[] label = Encoding.UTF8.GetBytes("ztlr:s|");
            byte[] buf = new byte[label.Length + salt.Length];
            Buffer.BlockCopy(label, 0, buf, 0, label.Length);
            Buffer.BlockCopy(salt, 0, buf, label.Length, salt.Length);

            using var hmac = new HMACSHA256(projectKey);
            byte[] result = hmac.ComputeHash(buf);

            // zero memory for security
            CryptographicOperations.ZeroMemory(buf);
            CryptographicOperations.ZeroMemory(label);

            return result;
        }

        public static byte[] KdfLabel(byte[] key, string label)
        {
            byte[] labelBytes = Encoding.UTF8.GetBytes(label);
            byte[] result;

            using (var hmac = new HMACSHA256(key))
                result = hmac.ComputeHash(labelBytes);

            CryptographicOperations.ZeroMemory(labelBytes);
            return result;
        }
        public static void DeriveEncMacKeys(byte[] fileKey, out byte[] encKey, out byte[] macKey)
        {
            encKey = KdfLabel(fileKey, "ztlr:enc|");
            macKey = KdfLabel(fileKey, "ztlr:mac|");
        }

        public static byte[] ComputeHmac(byte[] macKey, params byte[][] parts)
        {
            using var hmac = new HMACSHA256(macKey);
            foreach (var part in parts)
            {
                hmac.TransformBlock(part, 0, part.Length, null, 0);
            }

            hmac.TransformFinalBlock(Array.Empty<byte>(), 0, 0);

            return hmac.Hash;
        }

        public static byte[] Decrypt(byte[] blob, byte[] projectKey)
        {
            using var ms = new MemoryStream(blob, false);
            using var br = new BinaryReader(ms, Encoding.UTF8, true);

            if (br.ReadUInt32() != 0x524C545A)
                throw new CryptographicException("bad magic");

            if (br.ReadByte() != 49)
                throw new CryptographicException("bad alg");

            byte saltLen = br.ReadByte();
            byte ivLen = br.ReadByte();
            byte macLen = br.ReadByte();
            br.ReadByte();
            byte[] salt = br.ReadBytes(16);
            byte[] iv = br.ReadBytes(16);
            var len = ms.Length;
            byte[] cipher = br.ReadBytes((int)(ms.Length - ms.Position - macLen));
            Console.WriteLine(cipher.Length);
            byte[] mac = br.ReadBytes(32);

            byte[] fileKey = DeriveKey(projectKey, salt);
            DeriveEncMacKeys(fileKey, out byte[] encKey, out byte[] macKey);

            byte[] aad = BuildAAD();
            byte[] computedMac = ComputeHmac(macKey, aad,salt, iv, cipher);
            if (!CryptographicOperations.FixedTimeEquals(computedMac, mac))
                throw new CryptographicException("integrity check failed");

            using var aes = Aes.Create();
            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.PKCS7;
            aes.KeySize = 256;
            aes.Key = encKey;
            aes.IV = iv;

            using var dec = aes.CreateDecryptor();
            return dec.TransformFinalBlock(cipher, 0, cipher.Length);
        }
    }
}
