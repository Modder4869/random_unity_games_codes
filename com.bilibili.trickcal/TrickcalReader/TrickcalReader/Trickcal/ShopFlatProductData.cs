using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ShopFlatProductData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public FlatProductType FlatProductType { get; set; }
    [Key(2)]
    public int DayCount { get; set; }
    [Key(3)]
    public int ItemUid { get; set; }
    [Key(4)]
    public int ItemCount { get; set; }
    [Key(5)]
    public RewardType RewardType { get; set; }
    [Key(6)]
    public FlatEmphasisType EmphasisType { get; set; }
    [Key(7)]
    public bool OutDisplayType { get; set; }
    [Key(8)]
    public string SlotUIType { get; set; }
}
