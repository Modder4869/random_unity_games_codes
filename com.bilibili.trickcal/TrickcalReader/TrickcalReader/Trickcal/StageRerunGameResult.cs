using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class StageRerunGameResult {
    [Key(0)]
    public BaseStageGameResult Base { get; set; }
    [Key(1)]
    public StagePowerData PowerData { get; set; }
}
