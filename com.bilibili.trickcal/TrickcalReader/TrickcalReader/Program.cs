using MessagePack;
using Newtonsoft.Json;
using System.IO.Compression;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using Trickcal.Shared;
namespace TrickcalTableTools
{
    public static class SerializeExtensions
    {
        public static int Read7BitEncodedInt32(Stream stream)
        {
            int result = 0, shift = 0;
            while (true)
            {
                int b = stream.ReadByte();
                if (b < 0) throw new EndOfStreamException();
                result |= (b & 0x7F) << shift;
                if ((b & 0x80) == 0) break;
                shift += 7;
            }
            return result;
        }

        public static int Read32BitEncodedInt32(Stream stream)
        {
            byte[] buf = new byte[4];
            stream.ReadExactly(buf, 0, 4);
            return BitConverter.ToInt32(buf, 0);
        }

        public static string ReadString(Stream stream)
        {
            int length = Read32BitEncodedInt32(stream);
            if (length == 0) return null;                // LABEL_20
            if (length == 1) return string.Empty;        // length == 1 → String.Empty

            int n = length - 1;                          // actual byte count

            if (n <= 512)
            {
                // Stack allocation path
                Span<byte> buffer = stackalloc byte[n];
                stream.ReadExactly(buffer);
                return Encoding.UTF8.GetString(buffer);
            }
            else
            {
                // PooledArray path (heap)
                byte[] buffer = new byte[n];
                stream.ReadExactly(buffer);
                return Encoding.UTF8.GetString(buffer);
            }
        }
    }
    public static class GameCrypto
    {
        // Values extracted from decompiled SecurityPlayerPrefs.cctor
        private static readonly byte[] Salt = { 0x16, 0x16, 0x16, 0x01, 0x1C, 0x0E, 0x48, 0x16 };
        private const string Password = "fjioe034<>A.3Y<#E>%)KGB";
        private const int Iterations = 1000;
        private const int KeySize = 32; // 256 bits
        private const int IvSize = 16;  // 128 bits

        private static readonly Lazy<(byte[] Key, byte[] Iv)> _keyIv =
            new Lazy<(byte[], byte[])>(() =>
            {
                using var derive = new Rfc2898DeriveBytes(
                    Password,
                    Salt,
                    Iterations,
                    HashAlgorithmName.SHA1
                );
                byte[] key = derive.GetBytes(KeySize);
                byte[] iv = derive.GetBytes(IvSize);
                return (key, iv);
            });
        private static (byte[] Key, byte[] Iv) GetKeyAndIv() => _keyIv.Value;
        public static byte[] DecryptData(byte[] ciphertext)
        {
            (byte[] key, byte[] iv) = GetKeyAndIv();
            using var aes = Aes.Create();
            aes.Key = key;
            aes.IV = iv;
            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.PKCS7;

            using var input = new MemoryStream(ciphertext);
            using var decryptor = aes.CreateDecryptor();
            using var cs = new CryptoStream(input, decryptor, CryptoStreamMode.Read);
            using var output = new MemoryStream();
            cs.CopyTo(output);
            return output.ToArray();
        }

        public static MemoryStream DecryptAGUtilStream(Stream encryptedStream)
        {
            byte[] iv = new byte[16];
            if (encryptedStream.Read(iv, 0, 16) != 16)
                throw new InvalidDataException("Stream too short – missing IV.");
            byte[] keyBytes = Encoding.ASCII.GetBytes("b1l1bili");
            byte[] intBytes = new byte[4];
            intBytes[0] = (byte)(keyBytes[0] ^ iv[15]);
            intBytes[1] = (byte)(keyBytes[1] ^ iv[14]);
            intBytes[2] = (byte)(keyBytes[2] ^ iv[13]);
            intBytes[3] = (byte)(keyBytes[3] ^ iv[12]);

            int X = BitConverter.ToInt32(intBytes, 0);
            string password = "b1l1bili" + X;
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            byte[] aesKey = SHA256.HashData(passwordBytes);
            using var aes = Aes.Create();
            aes.Key = aesKey;
            aes.IV = iv;
            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.PKCS7;

            using var cryptoStream = new CryptoStream(encryptedStream, aes.CreateDecryptor(), CryptoStreamMode.Read);
            using var deflate = new DeflateStream(cryptoStream, CompressionMode.Decompress);
            var output = new MemoryStream();
            deflate.CopyTo(output);
            output.Position = 0;
            return output;
        }
    }

    public static class TableLoader
    {
        //public static Dictionary<Type, List<object>> LoadDataTable(
        //    Stream stream,
        //    Dictionary<string, Type> propertyTypeMap)
        //{
        //    int tableTypeValue = SerializeExtensions.Read7BitEncodedInt32(stream);
        //    var tableType = (TableFileType)tableTypeValue;
        //    var member = typeof(TableFileType).GetMember(tableType.ToString())[0];
        //    var attr = member.GetCustomAttribute<TableFileTargetAttribute>();

        //    int headerCount = SerializeExtensions.Read7BitEncodedInt32(stream);
        //    var headers = new List<(string key, string name, int length)>();
        //    for (int i = 0; i < headerCount; i++)
        //    {
        //        string key = SerializeExtensions.ReadString(stream);
        //        string name = SerializeExtensions.ReadString(stream);
        //        int length = SerializeExtensions.Read32BitEncodedInt32(stream);
        //        headers.Add((key, name, length));
        //    }
        //    Console.WriteLine(headerCount);
        //    var rowResults = new Dictionary<Type, List<object>>();
        //    var loadedValues = new List<object>();

        //    var options = MessagePackSerializerOptions.Standard
        //        .WithCompression(MessagePackCompression.Lz4BlockArray);

        //    foreach (var (key, _, dataLength) in headers)
        //    {
        //        if (!propertyTypeMap.TryGetValue(key, out Type propertyType))
        //        {
        //            stream.Seek(dataLength, SeekOrigin.Current);
        //            continue;
        //        }

        //        byte[] chunk = new byte[dataLength];
        //        stream.ReadExactly(chunk, 0, dataLength);
        //        object deserialized = MessagePackSerializer.Deserialize(propertyType, chunk, options);
        //        loadedValues.Add(deserialized);

        //        if (deserialized is System.Collections.IEnumerable enumerable)
        //        {
        //            foreach (object row in enumerable)
        //            {
        //                Type rowType = row.GetType();
        //                if (!rowResults.ContainsKey(rowType))
        //                    rowResults[rowType] = new List<object>();
        //                rowResults[rowType].Add(row);
        //            }
        //        }
        //        else
        //        {
        //            Type t = deserialized.GetType();
        //            if (!rowResults.ContainsKey(t))
        //                rowResults[t] = new List<object>();
        //            rowResults[t].Add(deserialized);
        //        }
        //    }

        //    return rowResults;
        //}
        public static List<object> LoadDataTable(
    Stream stream,
    Dictionary<string, Type> propertyTypeMap)
        {
            int tableTypeValue = SerializeExtensions.Read7BitEncodedInt32(stream);
            var tableType = (TableFileType)tableTypeValue;
            var member = typeof(TableFileType).GetMember(tableType.ToString())[0];
            var attr = member.GetCustomAttribute<TableFileTargetAttribute>();

            int headerCount = SerializeExtensions.Read7BitEncodedInt32(stream);
            var headers = new List<(string key, string name, int length)>();
            for (int i = 0; i < headerCount; i++)
            {
                string key = SerializeExtensions.ReadString(stream);
                string name = SerializeExtensions.ReadString(stream);
                int length = SerializeExtensions.Read32BitEncodedInt32(stream);
                headers.Add((key, name, length));
            }
            //Console.WriteLine(headerCount);

            var allRows = new List<object>();
            var options = MessagePackSerializerOptions.Standard
                .WithCompression(MessagePackCompression.Lz4BlockArray);

            foreach (var (key, _, dataLength) in headers)
            {
                if (!propertyTypeMap.TryGetValue(key, out Type propertyType))
                {
                    //Console.WriteLine($"  SKIP unknown key: {key} (length {dataLength})");
                    stream.Seek(dataLength, SeekOrigin.Current);
                    continue;
                }

                //Console.Write($"  DESERIALIZE {key} as {propertyType.Name} ... ");
                try
                {
                    byte[] chunk = new byte[dataLength];
                    stream.ReadExactly(chunk, 0, dataLength);
                    object deserialized = MessagePackSerializer.Deserialize(propertyType, chunk, options);

                    if (deserialized is System.Collections.IEnumerable enumerable)
                    {
                        int count = 0;
                        foreach (object row in enumerable)
                        {
                            allRows.Add(row);
                            count++;
                        }
                    }
                    else
                    {
                        allRows.Add(deserialized);
                        Console.WriteLine("OK (single object)");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"FAILED: {ex.Message}");
                }
            }

            return allRows;
        }
        public static DialogueChapterTableUnit LoadDialogueChapterFromBytes(
            Stream readStream)
        {
            int typeVal = SerializeExtensions.Read7BitEncodedInt32(readStream);
            var tableType = (TableFileType)typeVal;
            var member = typeof(TableFileType).GetMember(tableType.ToString())[0];
            var attr = member.GetCustomAttribute<TableFileTargetAttribute>();
            if (attr == null)
                throw new InvalidDataException($"Table type not found: {tableType}");

            var options = MessagePackSerializerOptions.Standard
                .WithCompression(MessagePackCompression.Lz4BlockArray);
            var unit = MessagePackSerializer.Deserialize<DialogueChapterTableUnit>(readStream, options);

            return unit;
        }

        public static object LoadTableAuto(
            Stream stream,
            Dictionary<string, Type> propertyTypeMap = null,
            int chapterUid = 0)
        {
            long pos = stream.Position;
            int typeVal = SerializeExtensions.Read7BitEncodedInt32(stream);
            stream.Seek(pos, SeekOrigin.Begin);

            var tableType = (TableFileType)typeVal;

            switch (tableType)
            {
                case TableFileType.TrickcalDialogueTable:
                    return LoadDialogueChapterFromBytes(stream);
                case TableFileType.ScenarioTextKr:
                case TableFileType.ScenarioTextEn:
                case TableFileType.ScenarioTextJp:
                case TableFileType.ScenarioTextZh_chs:
                case TableFileType.ScenarioTextZh_cht:
                    return LoadDataTable(stream, propertyTypeMap);
                case TableFileType.TrickcalTables:
                case TableFileType.Kr:
                case TableFileType.En:
                case TableFileType.Jp:
                case TableFileType.Zh_chs:
                case TableFileType.Zh_cht:
                    return LoadDataTable(stream, propertyTypeMap);
                default:
                    throw new("Unsupported TableType ..");

            }
        }
        public static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Usage: TrickcalReader.exe <inputDir> <outputDir>");
                return;
            }

            string inputDir = args[0];
            string outputDir = args[1];

            if (!Directory.Exists(inputDir))
            {
                Console.WriteLine("Input directory does not exist.");
                return;
            }

            Directory.CreateDirectory(outputDir);

            string[] allFiles = Directory.GetFiles(inputDir, "*.bytes", SearchOption.AllDirectories);
            int total = allFiles.Length, ok = 0, fail = 0;

            foreach (string filePath in allFiles)
            {
                string relPath = Path.GetRelativePath(inputDir, filePath);
                string outSubDir = Path.GetDirectoryName(Path.Combine(outputDir, relPath))!;
                Directory.CreateDirectory(outSubDir);

                string fileName = Path.GetFileName(filePath);
                string jsonFileName = Path.ChangeExtension(fileName, ".json");
                string jsonFilePath = Path.Combine(outSubDir, jsonFileName);
                if(filePath.Contains("GameData.TowerBattle.bytes") || filePath.Contains("TrickcalTables.client.bytes"))
                {
                    continue; //skip because im too lazy to dump newest version schemas
                }
                try
                {
                    byte[] encrypted = File.ReadAllBytes(filePath);
                    byte[] plain = GameCrypto.DecryptData(encrypted);

                    using var stream = new MemoryStream(plain);
                    object tableData = TableLoader.LoadTableAuto(stream, TablePropertyMap.Map);

                    string json = JsonConvert.SerializeObject(tableData, Formatting.Indented);
                    File.WriteAllText(jsonFilePath, json);

                    Console.WriteLine($"[{ok + fail + 1}/{total}] {relPath} -> OK");
                    ok++;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[{ok + fail + 1}/{total}] {relPath} -> FAILED: {ex.Message}");
                    fail++;
                }
            }

            Console.WriteLine($"Done. OK: {ok}, FAIL: {fail}");
        }

    }
    }