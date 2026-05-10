using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class FoodPreferenceData : TableItem<TableData> {
    [Key(0)]
    public int HeroUid { get; set; }
    [Key(1)]
    public FoodPreferenceType PreferenceType { get; set; }
    [Key(2)]
    public int FoodUid { get; set; }
    [Key(3)]
    public string ChefNote { get; set; }
}
