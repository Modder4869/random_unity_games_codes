using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

//
// ===========================================================
//                 MT19937 (IL2CPP-accurate)
// ===========================================================
public class RandomMT
{
    const int N = 624;
    const int M = 397;

    const uint MATRIX_A = 0x9908B0DF;  // -1727483681
    const uint UPPER_MASK = 0x80000000;
    const uint LOWER_MASK = 0x7FFFFFFF;

    readonly uint[] mag01 = new uint[2] { 0U, MATRIX_A };

    uint[] mt = new uint[N];
    int mti = N + 1;

    public RandomMT(uint seed)
    {
        InitGenRand(seed);
    }

    // IL2CPP version of: mt[0] = seed; for(i=1;i<N;i++)
    void InitGenRand(uint seed)
    {
        mt[0] = seed;
        for (mti = 1; mti < N; mti++)
        {
            uint prev = mt[mti - 1];
            uint x = prev ^ (prev >> 30);
            mt[mti] = (uint)(1812433253u * x + (uint)mti);
        }
    }

    // Generate next 624 numbers
    void Twist()
    {
        uint y;

        for (int i = 0; i < N - M; i++)
        {
            y = (mt[i] & UPPER_MASK) | (mt[i + 1] & LOWER_MASK);
            mt[i] = mt[i + M] ^ (y >> 1) ^ mag01[y & 1];
        }

        for (int i = N - M; i < N - 1; i++)
        {
            y = (mt[i] & UPPER_MASK) | (mt[i + 1] & LOWER_MASK);
            mt[i] = mt[i + (M - N)] ^ (y >> 1) ^ mag01[y & 1];
        }

        y = (mt[N - 1] & UPPER_MASK) | (mt[0] & LOWER_MASK);
        mt[N - 1] = mt[M - 1] ^ (y >> 1) ^ mag01[y & 1];

        mti = 0;
    }

    // Next 32-bit integer
    public uint NextUInt()
    {
        if (mti >= N)
            Twist();

        uint y = mt[mti++];

        // IL2CPP MT tempering matches standard MT19937:
        y ^= y >> 11;
        y ^= (y << 7) & 0x9D2C5680u;
        y ^= (y << 15) & 0xEFC60000u;
        y ^= y >> 18;

        return y;
    }

    public byte NextByte() => (byte)NextUInt();
}

//
// ===========================================================
//                          DECODER
// ===========================================================
public static class ObfuscatedDecoder
{
    public static byte[] DecodeToBin(byte[] src)
    {
        if (src == null || src.Length < 4)
            return Array.Empty<byte>();

        List<byte> outList = new List<byte>();

        //
        // Build MT seed from bytes 0..3
        //
        uint seed =
            (uint)(src[0]
            | (src[1] << 8)
            | (src[2] << 16)
            | (src[3] << 24));

        RandomMT mt = new RandomMT(seed);

        int size = src.Length;

        if (size == 4)
            return Array.Empty<byte>();

        //
        // value_2 = MT.Next() ^ src[4]
        //
        byte firstCipher = src[4];
        byte firstXor = (byte)(mt.NextByte() ^ firstCipher);

        int index = 5;

        //
        // Main loop
        //
        while (index < size)
        {
            byte cipher = src[index++];
            byte value = (byte)(mt.NextByte() ^ cipher);

            if (value != firstXor)
            {
                // Normal output byte
                outList.Add(value);
                continue;
            }

            //
            // Special branch (value == firstXor)
            //
            if (index >= size)
                break;

            byte cipher2 = src[index++];
            byte rnd2 = mt.NextByte();
            byte diff = (byte)(rnd2 ^ cipher2);

            if (rnd2 != cipher2)
            {
                //
                // RLE-like AddCopy
                //
                if (index >= size)
                    break;

                byte cipher3 = src[index++];
                byte count = (byte)(mt.NextByte() ^ cipher3);

                int start = outList.Count - diff;
                for (int i = 0; i < count; i++)
                {
                    if (start + i < 0 || start + i >= outList.Count)
                        break; // safety

                    outList.Add(outList[start + i]);
                }
            }
            else
            {
                //
                // Literal: push firstXor
                //
                outList.Add(firstXor);
            }
        }

        return outList.ToArray();
    }
}

//
// ===========================================================
//                     FILE TOOL EXAMPLE
// ===========================================================
public static class DecodeTool
{
    public static void DecodeFile(string input, string output)
    {
        byte[] src = File.ReadAllBytes(input);
        byte[] decoded = ObfuscatedDecoder.DecodeToBin(src);
        File.WriteAllText(output, Encoding.UTF8.GetString(decoded));
    }

    
}
public class Program()
{
    public static void Main(string[] args)
    {
        //if (args.Length != 2)
        //{
        //    Console.WriteLine("Usage: DecodeTool.exe <input> <output>");
        //    return;
        //}
        string input = @"D:\Users\ASUS\Downloads\IDA9.0\TrimmingCardData.bytes";
        string output = "TrimmingCardData.json";
        DecodeTool.DecodeFile(input, output);
        Console.WriteLine("Done.");
    }

}
