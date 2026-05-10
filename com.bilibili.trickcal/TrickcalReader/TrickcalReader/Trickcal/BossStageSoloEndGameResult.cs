using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class BossStageSoloEndGameResult {
    [Key(0)]
    public int PauseTimeMilliSeconds { get; set; }
    [Key(1)]
    public int PlayTimeMilliSeconds { get; set; }
    [Key(2)]
    public StageWaveHeroTeamInfo WaveHeroTeamInfo { get; set; }
    [Key(3)]
    public long EnemyTotalHeal { get; set; }
    [Key(4)]
    public long EnemyTotalShield { get; set; }
    [Key(5)]
    public List<StageWaveCardBuyInfo> CardBuyInfos { get; set; }
    [Key(6)]
    public short StartCoin { get; set; }
    [Key(7)]
    public int DeathCount { get; set; }
    [Key(8)]
    public StagePowerData PowerData { get; set; }
}
