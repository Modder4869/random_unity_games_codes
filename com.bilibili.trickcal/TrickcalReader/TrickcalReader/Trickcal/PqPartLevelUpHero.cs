using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqPartLevelUpHero {
    [Key(0)]
    public int HeroId { get; set; }
}
