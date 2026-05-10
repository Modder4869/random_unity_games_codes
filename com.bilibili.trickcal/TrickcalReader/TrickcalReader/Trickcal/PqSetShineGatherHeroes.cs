using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqSetShineGatherHeroes {
    [Key(0)]
    public int[] HeroIds { get; set; }
}
