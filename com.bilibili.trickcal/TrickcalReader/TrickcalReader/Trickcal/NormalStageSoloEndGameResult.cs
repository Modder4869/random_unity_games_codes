using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class NormalStageSoloEndGameResult {
    [Key(0)]
    public List<StageSoloEndWaveInfo> StageWaveInfos { get; set; }
    [Key(1)]
    public bool IsCheater { get; set; }
    [Key(2)]
    public StagePowerData PowerData { get; set; }
}
