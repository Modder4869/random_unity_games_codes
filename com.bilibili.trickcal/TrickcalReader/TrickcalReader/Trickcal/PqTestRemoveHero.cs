using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestRemoveHero {
    [Key(0)]
    public int HeroId { get; set; }
}
