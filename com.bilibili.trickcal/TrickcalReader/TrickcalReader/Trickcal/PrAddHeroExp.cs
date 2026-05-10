using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrAddHeroExp {
    [Key(0)]
    public short AddCount { get; set; }
    [Key(1)]
    public short LevelUpCount { get; set; }
}
