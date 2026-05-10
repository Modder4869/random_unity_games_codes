using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class GameEventData {
    [Key(0)]
    public GameEventType Type { get; set; }
    [Key(1)]
    public DateTime StartTime { get; set; }
    [Key(2)]
    public DateTime EndTime { get; set; }
    [Key(3)]
    public long[] Data { get; set; }
}
