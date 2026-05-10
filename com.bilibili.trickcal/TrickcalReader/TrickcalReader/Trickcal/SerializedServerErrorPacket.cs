using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SerializedServerErrorPacket {
    [Key(0)]
    public int RequestId { get; set; }
    [Key(1)]
    public string Message { get; set; }
}
