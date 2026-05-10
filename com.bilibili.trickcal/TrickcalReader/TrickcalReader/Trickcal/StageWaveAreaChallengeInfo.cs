using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class StageWaveAreaChallengeInfo {
    [Key(0)]
    public List<StageAugmentDrawInfo> StageAugmentDrawInfos { get; set; }
}
