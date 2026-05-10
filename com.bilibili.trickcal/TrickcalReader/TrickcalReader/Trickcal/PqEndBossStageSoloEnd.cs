using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqEndBossStageSoloEnd {
    [Key(0)]
    public int StagePlayKey { get; set; }
    [Key(1)]
    public BossStageSoloEndGameResult GameResult { get; set; }
    [Key(2)]
    public BattleValidationInfo BattleValidationInfo { get; set; }
    [Key(3)]
    public bool IsCheat { get; set; }
}
