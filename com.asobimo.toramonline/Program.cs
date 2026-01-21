using System;
using System.Buffers.Binary;

class Program
{

    public static void AssetDecrypt(byte[] data)
    {
        int size = data.Length & ~3;
        int words = size / 4;

        if (words < 1)
            return;

        uint[] w = new uint[words];
        uint[] original = new uint[words];

        uint firstWord = BinaryPrimitives.ReadUInt32BigEndian(data.AsSpan(0, 4));
        uint key = firstWord ^ 0x556E6974;
        Console.WriteLine($"Computed key: 0x{key:X8}");
        for (int i = 0; i < words; i++)
        {
            int p = i * 4;
            w[i] = BinaryPrimitives.ReadUInt32BigEndian(data.AsSpan(p, 4));
            original[i] = w[i];
        }
        //Console.Write($"block 0x{w[0]:X8} XOR key 0x{key:X8} => ");
        w[0] ^= key;
        //Console.WriteLine($"0x{w[0]:X8}");
        for (int i = 1; i < words; i++)
        {
            //Console.Write($"block 0x{w[i]:X8} XOR key 0x{key:X8} XOR prevEnc 0x{original[i - 1]:X8} => ");
            w[i] ^= key ^ original[i - 1];
            //Console.WriteLine($"0x{w[i]:X8}");
        }
        for (int i = 0; i < words; i++)
        {
            int p = i * 4;
            BinaryPrimitives.WriteUInt32BigEndian(data.AsSpan(p, 4), w[i]);
        }
    }
    static void Main(string[] args)
    {
        if (args.Length != 2)
        {
            Console.WriteLine("Usage: decrypt <input> <output>");
            return;
        }

        byte[] data = File.ReadAllBytes(args[0]);

        //uint key = 0x2E7468BC;
        AssetDecrypt(data);

        File.WriteAllBytes(args[1], data);
        Console.WriteLine("Done.");
    }
}
