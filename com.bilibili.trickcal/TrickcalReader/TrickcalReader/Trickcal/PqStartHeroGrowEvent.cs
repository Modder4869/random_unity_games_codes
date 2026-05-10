using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqStartHeroGrowEvent {
    [Key(0)]
    public int HeroGrowEventUid { get; set; }
}
