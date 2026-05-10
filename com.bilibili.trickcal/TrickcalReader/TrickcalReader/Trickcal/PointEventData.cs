using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PointEventData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int Group { get; set; }
    [Key(2)]
    public int Step { get; set; }
    [Key(3)]
    public int EventGoodsUid { get; set; }
    [Key(4)]
    public int NeedPoint { get; set; }
    [Key(5)]
    public PointEventRewardType[] RewardType { get; set; }
    [Key(6)]
    public int[] RewardUid { get; set; }
    [Key(7)]
    public int[] RewardValue { get; set; }
    [Key(8)]
    public int StepGroup { get; set; }
}
