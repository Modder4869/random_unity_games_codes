using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TitleHeroSettingData {
    [Key(0)]
    public int TitleAppearRatio { get; set; }
    [Key(1)]
    public List<int> HeroSkinUids { get; set; }
    [Key(2)]
    public bool IsAlways { get; set; }
}
