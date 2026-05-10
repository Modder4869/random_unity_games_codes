using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class WaveAugmentDrawRateData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int StageUid { get; set; }
    [Key(2)]
    public StageDifficultyType Difficulty { get; set; }
    [Key(3)]
    public int WaveOrder { get; set; }
    [Key(4)]
    public int _ { get; set; }
    [Key(5)]
    public int[] AugmentGroupUids { get; set; }
    [Key(6)]
    public int[] AugmentGroupRatios { get; set; }
    [Key(7)]
    public int ListCount { get; set; }
    [Key(8)]
    public int RewardOrder { get; set; }
    [Key(9)]
    public int ExceptionAugmentGroup { get; set; }
    [Key(10)]
    public WaveAugmentDrawGroupType GroupType { get; set; }
}
