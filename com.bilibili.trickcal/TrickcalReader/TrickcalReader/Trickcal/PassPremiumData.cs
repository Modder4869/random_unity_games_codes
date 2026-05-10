using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PassPremiumData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public RewardType[] PaidRewardTypes { get; set; }
    [Key(2)]
    public int[] PaidRewardUids { get; set; }
    [Key(3)]
    public int[] PaidRewardValues { get; set; }
}
