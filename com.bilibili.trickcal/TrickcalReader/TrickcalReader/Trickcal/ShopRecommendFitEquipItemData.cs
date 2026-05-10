using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ShopRecommendFitEquipItemData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int EquipGrade { get; set; }
    [Key(2)]
    public EquipType EquipType { get; set; }
    [Key(3)]
    public int ValueMin { get; set; }
    [Key(4)]
    public int ValueMax { get; set; }
    [Key(5)]
    public int[] PriceUids { get; set; }
    [Key(6)]
    public double[] PriceValues { get; set; }
}
