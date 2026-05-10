using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqEndStageGlobalBattleEventBoss {
    [Key(0)]
    public int StagePlayKey { get; set; }
    [Key(1)]
    public StageGlobalBattleEventBossGameResult GameResult { get; set; }
    [Key(2)]
    public bool? IsClear { get; set; }
    [Key(3)]
    public BattleValidationInfo BattleValidationInfo { get; set; }
}
