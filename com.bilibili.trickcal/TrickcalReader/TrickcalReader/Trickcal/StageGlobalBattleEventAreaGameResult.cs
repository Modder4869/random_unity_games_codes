using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class StageGlobalBattleEventAreaGameResult {
    [Key(0)]
    public BaseStageGameResult Base { get; set; }
    [Key(1)]
    public StagePowerData PowerData { get; set; }
}
