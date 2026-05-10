using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqUnlockHero {
    [Key(0)]
    public int HeroId { get; set; }
}
