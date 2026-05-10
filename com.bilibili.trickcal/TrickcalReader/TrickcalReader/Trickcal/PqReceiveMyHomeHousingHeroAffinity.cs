using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqReceiveMyHomeHousingHeroAffinity {
    [Key(0)]
    public int HeroId { get; set; }
}
