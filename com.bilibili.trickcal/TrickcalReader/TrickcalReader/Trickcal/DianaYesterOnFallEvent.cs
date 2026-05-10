using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class DianaYesterOnFallEvent {
    [Key(0)]
    public int EventIndex { get; set; }
    [Key(1)]
    public DateTime Timestamp { get; set; }
}
