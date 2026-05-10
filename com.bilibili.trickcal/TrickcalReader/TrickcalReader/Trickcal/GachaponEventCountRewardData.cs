using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class GachaponEventCountRewardData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int GachaponEventUid { get; set; }
    [Key(2)]
    public int Step { get; set; }
    [Key(3)]
    public int NeedCount { get; set; }
    [Key(4)]
    public RewardType[] RewardType { get; set; }
    [Key(5)]
    public int[] RewardUid { get; set; }
    [Key(6)]
    public int[] RewardValue { get; set; }
}
