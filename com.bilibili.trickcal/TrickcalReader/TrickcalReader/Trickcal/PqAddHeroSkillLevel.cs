using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqAddHeroSkillLevel {
    [Key(0)]
    public int HeroId { get; set; }
    [Key(1)]
    public int AddCount { get; set; }
    [Key(2)]
    public SkillType SkillType { get; set; }
}
