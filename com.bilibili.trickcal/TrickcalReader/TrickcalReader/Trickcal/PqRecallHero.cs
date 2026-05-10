using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqRecallHero {
    [Key(0)]
    public int HeroId { get; set; }
}
