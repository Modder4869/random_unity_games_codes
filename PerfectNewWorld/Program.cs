using System;
using System.IO;

public static class AbUtils
{
    public static int restoreByteCount = 0x40; // 64 bytes, must match IL2CPP static

    public static void AbRestore(byte[] array)
    {
        if (array == null || array.Length < restoreByteCount)
        {
            Console.Error.WriteLine($"error FileStreamEx:AbRestore array error array.Length={array?.Length}");
            return;
        }

        int rows = 8;
        int cols = restoreByteCount;
        int v6 = restoreByteCount / 8;
        if (v6 <= 0) v6 = 1;

        // Phase 1: build bit-plane matrix
        byte[,] m = new byte[rows, cols];
        int restoreByteCount_1 = 0;
        for (int v12 = 0; v12 < rows; v12++)
        {
            int size = restoreByteCount_1;
            int v15 = 0;
            for (int v14 = 0; v14 < v6; v14++)
            {
                for (int n8 = 0; n8 < 8; n8++)
                {
                    int inputPos = size;
                    if (inputPos >= restoreByteCount) break;
                    int col = v15 + n8;
                    if (col >= cols) break;
                    byte bit = (byte)((array[inputPos] >> n8) & 1);
                    m[v12, col] = bit;
                }
                size++;
                v15 += 8;
            }
            restoreByteCount_1 += v6;
        }

        // Phase 2: reconstruct bytes from matrix
        for (int i = 0; i < restoreByteCount; i++)
        {
            byte val = 0;
            for (int bit = 0; bit < 8; bit++)
            {
                if (bit >= rows) break;
                val |= (byte)(m[bit, i] << bit);
            }
            array[i] = val;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        string path = "D:\\Users\\ASUS\\Downloads\\IDA9.0\\data1.bundle";
        byte[] data = File.ReadAllBytes(path);

        Console.WriteLine($"Input length = 0x{data.Length:X}");

        AbUtils.restoreByteCount = 0x40; // 64 bytes
        AbUtils.AbRestore(data);

        File.WriteAllBytes(path+"_pwdec", data);
        Console.WriteLine("Restored bytes written to data16623_restored.bin");
    }
}