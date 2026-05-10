using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SerializedResponsePacket {
    [Key(0)]
    public int RequestId { get; set; }
    [Key(1)]
    public ResultCode ResultCode { get; set; }
    [Key(2)]
    public int MessageTypeAlias { get; set; }
    [Key(3)]
    public byte[] MessageBytes { get; set; }
    [Key(4)]
    public byte[] UcChangesBytes { get; set; }
    [Key(5)]
    public byte[] RewardDataBytes { get; set; }
}
