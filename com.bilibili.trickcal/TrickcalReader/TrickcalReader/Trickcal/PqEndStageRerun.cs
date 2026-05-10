using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqEndStageRerun {
    [Key(0)]
    public int StagePlayKey { get; set; }
    [Key(1)]
    public StageRerunGameResult GameResult { get; set; }
    [Key(2)]
    public BattleValidationInfo BattleValidationInfo { get; set; }
}
