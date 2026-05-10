using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class StageWaveInfo {
    [Key(0)]
    public int PauseTimeMilliSeconds { get; set; }
    [Key(1)]
    public int PlayTimeMilliSeconds { get; set; }
    [Key(2)]
    public List<StageWaveCardDrawInfo> CardDraws { get; set; }
    [Key(3)]
    public StageWaveHeroTeamInfo WaveHeroTeamInfo { get; set; }
    [Key(4)]
    public bool IsClear { get; set; }
    [Key(5)]
    public bool IsFastBattle { get; set; }
}
