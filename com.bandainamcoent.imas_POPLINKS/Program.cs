Console.WriteLine("Hello, World!");
var encFile = File.ReadAllBytes(@"b1101a83b56d190036d71e9482baac76949e16c91135b5f80a726bfe5ebcd2ee");
var keyData = File.ReadAllBytes(@"0x7984ce6000_0_32768_0key");
var maskOffset = encFile.Length % keyData.Length;
Console.WriteLine(encFile.Length % keyData.Length);
for (var i = 0; i < encFile.Length; i++)
{
    encFile[i] ^= keyData[maskOffset % keyData.Length];
    maskOffset++;
}
File.WriteAllBytes("imaspop.bin", encFile);
