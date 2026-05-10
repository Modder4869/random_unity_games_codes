using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ShopRecommendGoodsFitOtherData : TableItem<TableData> {
    [Key(0)]
    public int UserLevel { get; set; }
    [Key(1)]
    public int[] FitOtherItemGroupIds { get; set; }
}
