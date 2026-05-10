using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class StageSoloEndWaveInfo {
    [Key(0)]
    public int PauseTimeMilliSeconds { get; set; }
    [Key(1)]
    public int PlayTimeMilliSeconds { get; set; }
    [Key(2)]
    public List<StageWaveCardBuyInfo> CardBuyInfos { get; set; }
    [Key(3)]
    public StageWaveHeroTeamInfo WaveHeroTeamInfo { get; set; }
}
