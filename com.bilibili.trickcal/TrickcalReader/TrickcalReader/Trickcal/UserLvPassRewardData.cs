using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class UserLvPassRewardData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int Level { get; set; }
    [Key(2)]
    public RewardType FreeRewardType { get; set; }
    [Key(3)]
    public int FreeRewardUid { get; set; }
    [Key(4)]
    public int FreeRewardValue { get; set; }
    [Key(5)]
    public RewardType PaidRewardType { get; set; }
    [Key(6)]
    public int PaidRewardUid { get; set; }
    [Key(7)]
    public int PaidRewardValue { get; set; }
}
