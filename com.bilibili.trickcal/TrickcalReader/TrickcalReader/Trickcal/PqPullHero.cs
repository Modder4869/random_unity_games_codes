using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqPullHero {
    [Key(0)]
    public int HeroId { get; set; }
}
