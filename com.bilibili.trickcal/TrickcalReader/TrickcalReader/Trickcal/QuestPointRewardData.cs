using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class QuestPointRewardData : TableItem<TableData> {
    [Key(0)]
    public int EventUid { get; set; }
    [Key(1)]
    public int Step { get; set; }
    [Key(2)]
    public int NeedPoint { get; set; }
    [Key(3)]
    public RewardType RewardType { get; set; }
    [Key(4)]
    public int RewardUid { get; set; }
    [Key(5)]
    public int RewardValue { get; set; }
    [Key(6)]
    public QuestPointRewardSlotType SlotType { get; set; }
}
