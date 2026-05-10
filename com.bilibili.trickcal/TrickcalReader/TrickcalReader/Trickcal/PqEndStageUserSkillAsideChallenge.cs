using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqEndStageUserSkillAsideChallenge {
    [Key(0)]
    public int StagePlayKey { get; set; }
    [Key(1)]
    public StageUserSkillAsideChallengeGameResult GameResult { get; set; }
    [Key(2)]
    public BattleValidationInfo BattleValidationInfo { get; set; }
}
