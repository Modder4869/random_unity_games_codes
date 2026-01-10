using System.Security.Cryptography;
using System.Text;
// modify https://github.com/Razmoth/IKA9ntCrypto
namespace IKA9ntCrypto.CLI;
public class Program
{
    public static void Main(string[] args) => CommandLine.Init(args);
    public static void Run(Options o)
    {
        foreach(var file in o.Input?.GetFiles("*.*", SearchOption.AllDirectories) ?? [])
        {
            Console.WriteLine($"Processing {file.Name}...");

            o.Output?.Create();

            var outputPath = Path.Combine(o.Output!.FullName, Path.GetRelativePath(o.Input!.FullName, file.FullName));

            using FileStream inputFS = file.OpenRead();
            using FileStream outputFS = File.Open(outputPath, FileMode.Create);

            var salt = Encoding.UTF8.GetBytes(o.Extension ? Path.GetFileName(file.FullName) : Path.GetFileNameWithoutExtension(file.FullName));

            DeriveBytes deriveBytes = o.Derive switch
            {
                DeriveType.PBKDF1 => new PasswordDeriveBytes(o.Password!, salt, "SHA1", 100),
                DeriveType.PBKDF2 => new Rfc2898DeriveBytes(o.Password!, salt, 1000, HashAlgorithmName.SHA1),
                _ => throw new NotSupportedException()
            };

            using Aes aes = Aes.Create();

            aes.KeySize = o.KeySize;
            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.PKCS7;
            aes.Key = new byte[] { 0x39, 0x4b, 0x69, 0x25, 0x46, 0x37, 0x32, 0x44, 0x2d, 0x76, 0x6a, 0x4c, 0x71, 0x58, 0x66, 0x6e };
            aes.IV = new byte[] { 0x72, 0x48, 0x6b, 0x51, 0x48, 0x68, 0x43, 0x66, 0x54, 0x23, 0x45, 0x47, 0x41, 0x2e, 0x6b, 0x57 };

            using SeekableAesStream seekableAesStream = new(inputFS, aes.CreateEncryptor());

            seekableAesStream.CopyTo(outputFS);

            Console.WriteLine($"{file.Name} processed !!");
        }
    }
}