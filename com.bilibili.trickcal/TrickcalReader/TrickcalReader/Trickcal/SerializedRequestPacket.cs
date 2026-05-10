using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SerializedRequestPacket {
    [Key(0)]
    public int RequestId { get; set; }
    [Key(1)]
    public int MessageTypeAlias { get; set; }
    [Key(2)]
    public byte[] MessageBytes { get; set; }
}
