using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class StageTowerGameResult {
    [Key(0)]
    public int PauseTimeMilliSeconds { get; set; }
    [Key(1)]
    public int PlayTimeMilliSeconds { get; set; }
    [Key(2)]
    public StageWaveHeroTeamInfo WaveHeroTeamInfo { get; set; }
    [Key(3)]
    public bool IsCheater { get; set; }
    [Key(4)]
    public StagePowerData PowerData { get; set; }
}
