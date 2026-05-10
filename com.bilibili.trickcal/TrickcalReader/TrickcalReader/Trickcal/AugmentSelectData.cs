using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class AugmentSelectData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int AugmentGroup { get; set; }
    [Key(2)]
    public int AugmentLevelUid { get; set; }
    [Key(3)]
    public int DropRatio { get; set; }
    [Key(4)]
    public int AugmentUid { get; set; }
    [Key(5)]
    public int TargetTier { get; set; }
    [Key(6)]
    public bool FixAugment { get; set; }
    [Key(7)]
    public int EventUid { get; set; }
}
