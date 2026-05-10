using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class StageGlobalBattleEventBossGameResult {
    [Key(0)]
    public StageGlobalBattleEventBossWaveInfo[] WaveInfos { get; set; }
    [Key(1)]
    public StagePowerData PowerData { get; set; }
}
