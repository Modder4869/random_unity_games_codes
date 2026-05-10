using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestSetHeroMyHomeLifeStress {
    [Key(0)]
    public int HeroId { get; set; }
    [Key(1)]
    public short LifeStress { get; set; }
}
