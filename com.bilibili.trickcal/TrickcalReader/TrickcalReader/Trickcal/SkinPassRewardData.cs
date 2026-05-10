using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SkinPassRewardData : TableItem<TableData> {
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
    public RewardType[] PaidRewardTypes { get; set; }
    [Key(6)]
    public int[] PaidRewardUids { get; set; }
    [Key(7)]
    public int[] PaidRewardValues { get; set; }
    [Key(8)]
    public bool IsEmphasizable { get; set; }
}
