using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class HeroEquipRecipeData : TableItem<TableData> {
    [Key(0)]
    public int ItemEquipUid { get; set; }
    [Key(1)]
    public int[] RequireItemIdArray { get; set; }
    [Key(2)]
    public int[] RequireItemCountArray { get; set; }
}
