using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqAddEventHeroGroupLevel {
    [Key(0)]
    public int MixedEventUid { get; set; }
    [Key(1)]
    public int HeroId { get; set; }
    [Key(2)]
    public int TargetGroupUid { get; set; }
}
