using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqAddHeroGrade {
    [Key(0)]
    public int HeroId { get; set; }
}
