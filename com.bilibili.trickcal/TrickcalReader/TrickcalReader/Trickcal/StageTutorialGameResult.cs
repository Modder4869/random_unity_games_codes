using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class StageTutorialGameResult {
    [Key(0)]
    public BaseStageGameResult Base { get; set; }
    [Key(1)]
    public List<int> EndSlotUids { get; set; }
    [Key(2)]
    public StagePowerData PowerData { get; set; }
}
