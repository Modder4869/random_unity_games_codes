using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SerializedGlobalWeightVariableData {
    [Key(0)]
    public byte[] Bytes { get; set; }
    [Key(1)]
    public DateTime CreateTimeUtc { get; set; }
}
