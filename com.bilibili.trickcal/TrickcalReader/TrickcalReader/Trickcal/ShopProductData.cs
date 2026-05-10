using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ShopProductData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public RewardType RewardType { get; set; }
    [Key(2)]
    public int ItemUid { get; set; }
    [Key(3)]
    public int ItemCount { get; set; }
}
