using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class WWERewardData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int WWEId { get; set; }
    [Key(2)]
    public WWERewardType WWERewardType { get; set; }
    [Key(3)]
    public int TypeValue { get; set; }
    [Key(4)]
    public RewardType[] RewardTypes { get; set; }
    [Key(5)]
    public int[] RewardUids { get; set; }
    [Key(6)]
    public int[] RewardValues { get; set; }
}
