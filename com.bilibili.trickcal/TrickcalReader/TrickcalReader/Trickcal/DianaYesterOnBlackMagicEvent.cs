using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class DianaYesterOnBlackMagicEvent {
    [Key(0)]
    public int EventIndex { get; set; }
    [Key(1)]
    public DateTime Timestamp { get; set; }
    [Key(2)]
    public int BlackMagicUid { get; set; }
}
