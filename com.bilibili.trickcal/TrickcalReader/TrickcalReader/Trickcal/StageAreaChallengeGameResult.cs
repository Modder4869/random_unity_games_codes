using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class StageAreaChallengeGameResult {
    [Key(0)]
    public BaseStageGameResult Base { get; set; }
    [Key(1)]
    public StagePowerData PowerData { get; set; }
    [Key(2)]
    public StageAugmentInfo SelectedAugmentInfo { get; set; }
    [Key(3)]
    public List<StageWaveAreaChallengeInfo> WaveInfos { get; set; }
    [Key(4)]
    public StageAugmentInfo SelectedCheatAugmentInfo { get; set; }
}
