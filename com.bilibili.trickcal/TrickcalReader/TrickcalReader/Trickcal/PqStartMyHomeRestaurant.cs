using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqStartMyHomeRestaurant {
    [Key(0)]
    public int RecipeId { get; set; }
    [Key(1)]
    public int Count { get; set; }
    [Key(2)]
    public int MainCategoryId { get; set; }
}
