using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqEndStageAugmentChallenge {
    [Key(0)]
    public int StagePlayKey { get; set; }
    [Key(1)]
    public StageAugmentChallengeGameResult GameResult { get; set; }
    [Key(2)]
    public BattleValidationInfo BattleValidationInfo { get; set; }
}
