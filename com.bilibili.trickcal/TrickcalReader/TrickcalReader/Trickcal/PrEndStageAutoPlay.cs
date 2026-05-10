using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrEndStageAutoPlay {
    [Key(0)]
    public int[] AutoPlayedStageUids { get; set; }
    [Key(1)]
    public StageClearType[] AutoPlayedStageClearTypes { get; set; }
}
