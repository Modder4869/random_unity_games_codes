using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SerializedNotificationPacket {
    [Key(0)]
    public int MessageTypeAlias { get; set; }
    [Key(1)]
    public byte[] MessageBytes { get; set; }
    [Key(2)]
    public byte[] UcChangesBytes { get; set; }
    [Key(3)]
    public byte[] RewardDataBytes { get; set; }
}
