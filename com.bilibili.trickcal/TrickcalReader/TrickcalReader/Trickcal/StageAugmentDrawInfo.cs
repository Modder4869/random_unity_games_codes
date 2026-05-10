using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class StageAugmentDrawInfo {
    [Key(0)]
    public StageAugmentInfo[] StageAugmentInfos { get; set; }
    [Key(1)]
    public int SelectIndex { get; set; }
    [Key(2)]
    public bool IsAugmentSelectCancel { get; set; }
    [Key(3)]
    public int Level { get; set; }
}
