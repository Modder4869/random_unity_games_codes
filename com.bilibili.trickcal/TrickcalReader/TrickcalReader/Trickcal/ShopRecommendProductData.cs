using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ShopRecommendProductData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public ShopRecommendType RecommendType { get; set; }
    [Key(2)]
    public int RecommendTypeWeight { get; set; }
    [Key(3)]
    public int PriceUidProb1 { get; set; }
}
