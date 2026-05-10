using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ShopRecommendFitOtherItemData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int UserLevel { get; set; }
    [Key(2)]
    public int GroupId { get; set; }
    [Key(3)]
    public int ItemUid { get; set; }
    [Key(4)]
    public int ValueMin { get; set; }
    [Key(5)]
    public int ValueMax { get; set; }
    [Key(6)]
    public int DropWeight { get; set; }
    [Key(7)]
    public int[] PriceUids { get; set; }
    [Key(8)]
    public double[] PriceValues { get; set; }
}
