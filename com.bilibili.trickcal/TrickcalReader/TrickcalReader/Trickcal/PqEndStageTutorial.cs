using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqEndStageTutorial {
    [Key(0)]
    public int StagePlayKey { get; set; }
    [Key(1)]
    public StageTutorialGameResult GameResult { get; set; }
    [Key(2)]
    public BattleValidationInfo BattleValidationInfo { get; set; }
}
