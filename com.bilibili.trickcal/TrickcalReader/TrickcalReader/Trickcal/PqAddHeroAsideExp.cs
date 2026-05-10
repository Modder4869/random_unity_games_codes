using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqAddHeroAsideExp {
    [Key(0)]
    public int HeroId { get; set; }
    [Key(1)]
    public short AddCount { get; set; }
    [Key(2)]
    public TribeType HeartType { get; set; }
}
