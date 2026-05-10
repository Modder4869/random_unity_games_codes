using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public struct Goods {
    [Key(0)]
    public GoodsType Type { get; set; }
    [Key(1)]
    public int Value { get; set; }
    [Key(2)]
    public int Count { get; set; }
}
