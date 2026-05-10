using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqEndStageAreaChallenge {
    [Key(0)]
    public int StagePlayKey { get; set; }
    [Key(1)]
    public StageAreaChallengeGameResult GameResult { get; set; }
    [Key(2)]
    public BattleValidationInfo BattleValidationInfo { get; set; }
}
