using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqSetGuildMainHero {
    [Key(0)]
    public int HeroId { get; set; }
}
