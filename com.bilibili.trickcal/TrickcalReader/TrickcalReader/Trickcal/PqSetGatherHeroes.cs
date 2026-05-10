using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqSetGatherHeroes {
    [Key(0)]
    public int[] HeroIds { get; set; }
}
