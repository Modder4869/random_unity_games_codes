using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class UserSoloRaidStageClearHeroInfo {
    [Key(0)]
    public int[] Heroes { get; set; }
    [Key(1)]
    public short[] HeroLevels { get; set; }
    [Key(2)]
    public short[] HeroGrades { get; set; }
    [Key(3)]
    public int[] HeroSkins { get; set; }
}
