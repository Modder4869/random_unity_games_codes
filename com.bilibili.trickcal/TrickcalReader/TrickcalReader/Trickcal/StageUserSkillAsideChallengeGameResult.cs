using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class StageUserSkillAsideChallengeGameResult {
    [Key(0)]
    public BaseStageGameResult Base { get; set; }
    [Key(1)]
    public StagePowerData PowerData { get; set; }
    [Key(2)]
    public int Score { get; set; }
}
