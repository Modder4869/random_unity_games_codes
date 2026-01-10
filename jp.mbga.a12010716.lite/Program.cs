using System;
using System.Collections.Generic;
using System.IO;

public static class SystemIO
{
    public enum DECRIPTION_TYPE : int
    {
        UNITY_4_6_5_P4 = 1,
        UNITY_4_6_9_F1 = 2,
        UNITY_4_6_9_F1_01 = 3,
        UNITY_4_6_9_F1_02 = 4,
        UNITY_5_6_6_F2 = 5,
        UNITY_2019 = 6,
        UNITY_2021 = 7,
        UNITY_2021_3_38_F1 = 8,
    }

    private static readonly Dictionary<int, string> HeaderHexByType = new()
    {
        { (int)DECRIPTION_TYPE.UNITY_4_6_5_P4,        "556E6974795765620000000003332E552E7800342E362E357034000000" },
        { (int)DECRIPTION_TYPE.UNITY_4_6_9_F1,        "556E6974795765620000000003332E782E7800342E362E396631000000" },
        { (int)DECRIPTION_TYPE.UNITY_4_6_9_F1_01,     "556E6974795765620000000003332E782E7800342E362E396631000000" },
        { (int)DECRIPTION_TYPE.UNITY_4_6_9_F1_02,     "556E6974795765620000000003332E782E7800342E362E396631000000" },
        { (int)DECRIPTION_TYPE.UNITY_5_6_6_F2,        "556E69747946530000000006352E782E7800352E362E36663200000000" },
        { (int)DECRIPTION_TYPE.UNITY_2019,            "556E69747946530000000006352E782E7800323031392E342E39663100" },
        { (int)DECRIPTION_TYPE.UNITY_2021,            "556E69747946530000000008352E782E7800323032312E332E31366631" },
        { (int)DECRIPTION_TYPE.UNITY_2021_3_38_F1,    "556E69747946530000000008352E782E7800323032312E332E33386631" },
    };

    public static uint DecriptionInfoData(byte[] data, uint index, uint decriptKey)
    {
        uint v0 = data[index];
        uint v1 = data[index + 1];
        uint v2 = data[index + 2];
        uint v3 = data[index + 3];
        uint value = (v3 << 24) | (v2 << 16) | (v1 << 8) | v0;
        return value ^ decriptKey;
    }

    public static void ProcessFile(string inputPath, string outputPath)
    {
        Console.WriteLine($"[loading] {Path.GetFileName(inputPath)}");

        byte[] data = File.ReadAllBytes(inputPath);
        if (data.Length < 16)
        {
            Console.WriteLine($"[skip] {Path.GetFileName(inputPath)} (too small: {data.Length} bytes)");
            return;
        }
        uint decriptKey = DecriptionInfoData(data, 8u, 0x5E8310FAu);
        uint decriptKey_2 = decriptKey;
        uint decriptKey_1 = DecriptionInfoData(data, 0u, decriptKey);
        uint getStartIndex = DecriptionInfoData(data, 12u, decriptKey_1);
        uint type_1 = DecriptionInfoData(data, 4u, decriptKey_2);
        ushort type = (ushort)type_1;

        if (getStartIndex >= data.Length)
        {
            Console.WriteLine($"[SKIP] {inputPath} invalid index");
            return;
        }

        string headerHex = HeaderHexByType.TryGetValue((int)type_1, out var h)
            ? h
            : HeaderHexByType.GetValueOrDefault(type, null);

        byte[] headerBytes = headerHex != null ? Convert.FromHexString(headerHex) : Array.Empty<byte>();
        byte[] slice = data[(int)getStartIndex..];

        Directory.CreateDirectory(Path.GetDirectoryName(outputPath)!);
        using var ms = new MemoryStream();
        using var bw = new BinaryWriter(ms);
        bw.Write(headerBytes);
        bw.Write(slice);
        File.WriteAllBytes(outputPath, ms.ToArray());

        Console.WriteLine($"[OK] {Path.GetFileName(inputPath)} → {Path.GetFileName(outputPath)}");
    }

    public static void ProcessFolder(string inputFolder, string outputFolder)
    {
        if (!Directory.Exists(inputFolder))
        {
            Console.WriteLine($"Input folder not found: {inputFolder}");
            return;
        }

        foreach (var file in Directory.GetFiles(inputFolder, "*", SearchOption.AllDirectories))
        {
            string rel = Path.GetRelativePath(inputFolder, file);
            string outPath = Path.Combine(outputFolder, rel);
            ProcessFile(file, outPath);
        }

        Console.WriteLine("Done.");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        if (args.Length < 2)
        {
            Console.WriteLine(String.Format("{0}", "AAAAAAAAAA"));
            Console.WriteLine("Usage: pazuani <inputFolder> <outputFolder>");
            return;
        }

        string input = args[0];
        string output = args[1];
        SystemIO.ProcessFolder(input, output);
    }
}
