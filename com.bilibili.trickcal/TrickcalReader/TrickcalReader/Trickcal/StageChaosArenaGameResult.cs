using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class StageChaosArenaGameResult {
    [Key(0)]
    public int PauseTimeMilliSeconds { get; set; }
    [Key(1)]
    public int PlayTimeMilliSeconds { get; set; }
    [Key(2)]
    public StageWaveChaosArenaTeamInfo AlphaTeamInfo { get; set; }
    [Key(3)]
    public StageWaveChaosArenaTeamInfo BravoTeamInfo { get; set; }
    [Key(4)]
    public bool IsCheater { get; set; }
    [Key(5)]
    public StagePowerData PowerData { get; set; }
}
