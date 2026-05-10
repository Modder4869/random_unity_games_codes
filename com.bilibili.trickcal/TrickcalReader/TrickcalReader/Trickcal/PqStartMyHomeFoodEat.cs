using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqStartMyHomeFoodEat {
    [Key(0)]
    public int HeroId { get; set; }
    [Key(1)]
    public int FoodItemId { get; set; }
    [Key(2)]
    public bool CheckedOverFood { get; set; }
}
