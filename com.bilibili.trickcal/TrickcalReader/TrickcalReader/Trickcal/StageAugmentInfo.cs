using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class StageAugmentInfo {
    [Key(0)]
    public int AugmentUid { get; set; }
    [Key(1)]
    public int AugmentTier { get; set; }
}
