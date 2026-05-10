using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqAddEventHeroGrade {
    [Key(0)]
    public int MixedEventUid { get; set; }
    [Key(1)]
    public int HeroId { get; set; }
}
