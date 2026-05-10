using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqStartMyHomeProduction {
    [Key(0)]
    public int SlotIndex { get; set; }
    [Key(1)]
    public int RecipeId { get; set; }
    [Key(2)]
    public int Count { get; set; }
    [Key(3)]
    public int MainCategoryId { get; set; }
}
