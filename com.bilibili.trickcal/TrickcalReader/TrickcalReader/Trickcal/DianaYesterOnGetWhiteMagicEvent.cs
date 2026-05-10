using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class DianaYesterOnGetWhiteMagicEvent {
    [Key(0)]
    public int EventIndex { get; set; }
    [Key(1)]
    public DateTime Timestamp { get; set; }
    [Key(2)]
    public int WhiteMagicUid { get; set; }
}
