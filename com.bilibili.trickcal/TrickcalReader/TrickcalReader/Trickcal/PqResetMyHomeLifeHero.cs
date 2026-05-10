using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqResetMyHomeLifeHero {
    [Key(0)]
    public int HeroId { get; set; }
}
