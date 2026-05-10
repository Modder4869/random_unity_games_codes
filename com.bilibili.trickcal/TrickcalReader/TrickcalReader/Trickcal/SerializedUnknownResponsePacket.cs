using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SerializedUnknownResponsePacket {
    [Key(0)]
    public int RequestId { get; set; }
    [Key(1)]
    public int MessageTypeAlias { get; set; }
}
