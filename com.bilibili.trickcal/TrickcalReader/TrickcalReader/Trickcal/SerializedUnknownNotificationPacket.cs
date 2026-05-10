using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SerializedUnknownNotificationPacket {
    [Key(0)]
    public int MessageTypeAlias { get; set; }
}
