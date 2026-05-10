using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class CookingTycoonIngredientData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public CookingTycoonIngredientType Type { get; set; }
    [Key(2)]
    public CookingTycoonIngredientCategory Category { get; set; }
    [Key(3)]
    public int LimitNum { get; set; }
    [Key(4)]
    public int[] AvailableStageUid { get; set; }
}
