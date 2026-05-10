using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestSetHeroMyHomeLifeExp {
    [Key(0)]
    public int HeroId { get; set; }
    [Key(1)]
    public int LifeExp { get; set; }
}
