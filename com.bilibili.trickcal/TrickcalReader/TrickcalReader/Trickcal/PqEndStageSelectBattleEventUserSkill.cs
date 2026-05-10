using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqEndStageSelectBattleEventUserSkill {
    [Key(0)]
    public int StagePlayKey { get; set; }
    [Key(1)]
    public StageSelectBattleEventUserSkillGameResult GameResult { get; set; }
    [Key(2)]
    public BattleValidationInfo BattleValidationInfo { get; set; }
}
