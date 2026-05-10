using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqAddHeroAsideGrade {
    [Key(0)]
    public int HeroId { get; set; }
}
