using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class CookingTycoonCuisineData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int ContentsUid { get; set; }
    [Key(2)]
    public int[] IngredientUid { get; set; }
    [Key(3)]
    public int[] IngredientAmount { get; set; }
    [Key(4)]
    public bool[] IsRequired { get; set; }
    [Key(5)]
    public string[] Resource { get; set; }
}
