using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestAddHeroCount {
    [Key(0)]
    public int HeroId { get; set; }
    [Key(1)]
    public int Count { get; set; }
}
