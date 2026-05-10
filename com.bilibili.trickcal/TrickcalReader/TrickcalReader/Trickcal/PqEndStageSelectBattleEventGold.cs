using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqEndStageSelectBattleEventGold {
    [Key(0)]
    public int StagePlayKey { get; set; }
    [Key(1)]
    public StageSelectBattleEventGoldGameResult GameResult { get; set; }
    [Key(2)]
    public BattleValidationInfo BattleValidationInfo { get; set; }
}
