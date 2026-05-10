using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class DianaYesterOnBlockPlacedEvent {
    [Key(0)]
    public int EventIndex { get; set; }
    [Key(1)]
    public DateTime Timestamp { get; set; }
    [Key(2)]
    public int BlockUid { get; set; }
    [Key(3)]
    public float BlockXPosition { get; set; }
    [Key(4)]
    public float BlockHeight { get; set; }
}
