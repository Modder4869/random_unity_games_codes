using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqPartLevelUpHeroAside {
    [Key(0)]
    public int HeroId { get; set; }
    [Key(1)]
    public TribeType HeartType { get; set; }
}
