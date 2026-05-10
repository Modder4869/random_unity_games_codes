using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class FoodInfoData : TableItem<TableData> {
    [Key(0)]
    public TableBaseItemData ItemData { get; set; }
    [Key(1)]
    public FoodType Type { get; set; }
    [Key(2)]
    public FoodRarityType Rarity { get; set; }
    [Key(3)]
    public int AffinityValue { get; set; }
    [Key(4)]
    public int HighFood { get; set; }
}
