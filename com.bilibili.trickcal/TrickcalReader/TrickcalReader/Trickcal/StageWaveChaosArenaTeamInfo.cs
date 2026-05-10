using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class StageWaveChaosArenaTeamInfo {
    [Key(0)]
    public StageWaveHeroTeamInfo HeroTeamInfo { get; set; }
    [Key(1)]
    public int[] SelectedCards { get; set; }
    [Key(2)]
    public List<StageWaveMonsterInfo> AllianceMonsterInfos { get; set; }
}
