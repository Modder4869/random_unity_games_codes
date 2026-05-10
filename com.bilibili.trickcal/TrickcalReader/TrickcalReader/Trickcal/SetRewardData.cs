using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SetRewardData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int Step { get; set; }
    [Key(2)]
    public int ConditionValue { get; set; }
    [Key(3)]
    public int RewardUid { get; set; }
    [Key(4)]
    public int RewardValue { get; set; }
    [Key(5)]
    public RewardType RewardType { get; set; }
}
