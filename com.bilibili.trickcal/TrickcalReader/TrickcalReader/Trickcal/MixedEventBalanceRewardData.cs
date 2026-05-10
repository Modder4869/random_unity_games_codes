using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class MixedEventBalanceRewardData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int BalanceInfoUid { get; set; }
    [Key(2)]
    public short State { get; set; }
    [Key(3)]
    public RewardType[] RewardTypes { get; set; }
    [Key(4)]
    public int[] RewardUids { get; set; }
    [Key(5)]
    public int[] RewardValues { get; set; }
}
