using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class StageWaveHeroTeamInfo {
    [Key(0)]
    public List<StageWaveHeroInfo> HeroInfos { get; set; }
    [Key(1)]
    public List<StageWaveEffectInfo> WaveEffectInfos { get; set; }
}
