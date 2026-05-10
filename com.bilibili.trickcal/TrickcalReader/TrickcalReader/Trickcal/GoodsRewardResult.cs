using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class GoodsRewardResult {
    [Key(0)]
    public Goods Goods { get; set; }
    [Key(1)]
    public bool IsFirstDrop { get; set; }
}
