using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SerializedPingPacket {
    [Key(0)]
    public bool IsForStatistic { get; set; }
    [Key(1)]
    public string Message { get; set; }
}
