using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqAddHeroExp {
    [Key(0)]
    public int HeroId { get; set; }
    [Key(1)]
    public short AddExpCount { get; set; }
}
