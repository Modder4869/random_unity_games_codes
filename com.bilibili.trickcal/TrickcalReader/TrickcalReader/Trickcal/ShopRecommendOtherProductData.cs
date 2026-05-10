using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ShopRecommendOtherProductData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public ShopRecommendOtherType ShopRecommendOtherType { get; set; }
    [Key(2)]
    public int RecommendGroupWeight { get; set; }
}
