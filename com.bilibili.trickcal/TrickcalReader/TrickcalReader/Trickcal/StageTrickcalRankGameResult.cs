using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class StageTrickcalRankGameResult {
    [Key(0)]
    public int PauseTimeMilliSeconds { get; set; }
    [Key(1)]
    public int PlayTimeMilliSeconds { get; set; }
    [Key(2)]
    public StageWaveHeroTeamInfo AlphaTeamInfo { get; set; }
    [Key(3)]
    public StageWaveHeroTeamInfo BravoTeamInfo { get; set; }
    [Key(4)]
    public bool IsCheater { get; set; }
    [Key(5)]
    public int Phase { get; set; }
    [Key(6)]
    public StagePowerData PowerData { get; set; }
}
