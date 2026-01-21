public static class ObfuscateUtils
{

    public static void Decrypt(byte[] content)
    {
     byte[] unityfs_header =
    {
        0x55, 0x6E, 0x69, 0x74, 0x79, 0x46, 0x53, 0x00,
        0x00, 0x00, 0x00, 0x08, 0x35, 0x2E, 0x78, 0x2E
    };

        byte[] prefixKey = new byte[16];

        for (int i = 0; i < 16; i++)
        {
            prefixKey[i] = (byte)(content[i] ^ unityfs_header[i]);
        }
        int keyIndex = 0;
        int limit = Math.Min(256, content.Length);

        for (int i = 0; i < limit; i++)
        {
            content[i] ^= prefixKey[i % prefixKey.Length];
        }
        int offset = 256;
        while (offset < content.Length)
        {
            for (int i = 0; i < prefixKey.Length; i++)
            {
                int idx = offset + i;
                if (idx >= content.Length)
                    return;

                content[idx] ^= prefixKey[i];
            }
            offset *= 2;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        if (args.Length < 2)
        {
            Console.WriteLine("Usage: decrypt <input> <output>");
            return;
        }

        byte[] data = File.ReadAllBytes(args[0]);

        ObfuscateUtils.Decrypt(data);

        File.WriteAllBytes(args[1], data);

        Console.WriteLine("Decryption complete.");
    }
}
