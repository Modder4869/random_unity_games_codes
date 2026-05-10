using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserCardData {
    [Key(0)]
    public GoodsType Type { get; set; }
    [Key(1)]
    public short Level { get; set; }
    [Key(2)]
    public int Count { get; set; }
    [Key(3)]
    public DateTime OwnTime { get; set; }
}
