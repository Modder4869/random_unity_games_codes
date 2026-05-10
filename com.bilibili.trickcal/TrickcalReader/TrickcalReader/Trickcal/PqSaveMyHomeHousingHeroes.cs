using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqSaveMyHomeHousingHeroes {
    [Key(0)]
    public int[] HeroIds { get; set; }
}
