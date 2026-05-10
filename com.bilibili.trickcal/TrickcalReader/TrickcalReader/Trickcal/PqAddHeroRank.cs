using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqAddHeroRank {
    [Key(0)]
    public int HeroId { get; set; }
    [Key(1)]
    public int RankUpCount { get; set; }
}
