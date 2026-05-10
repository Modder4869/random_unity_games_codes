using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqSetUserMainProfileHero {
    [Key(0)]
    public int HeroId { get; set; }
}
