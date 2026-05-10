using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class RecordRewardData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int RecordTypeUid { get; set; }
    [Key(2)]
    public int Group { get; set; }
    [Key(3)]
    public int Value { get; set; }
    [Key(4)]
    public RewardType[] RewardTypes { get; set; }
    [Key(5)]
    public int[] RewardUids { get; set; }
    [Key(6)]
    public int[] RewardCounts { get; set; }
}
