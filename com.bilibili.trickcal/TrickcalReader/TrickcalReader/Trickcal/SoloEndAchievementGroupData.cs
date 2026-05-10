using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SoloEndAchievementGroupData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int Group { get; set; }
    [Key(2)]
    public int Step { get; set; }
    [Key(3)]
    public int Count { get; set; }
    [Key(4)]
    public bool IsInfinity { get; set; }
    [Key(5)]
    public int InfiniteRepeatCount { get; set; }
    [Key(6)]
    public int[] RewardUids { get; set; }
    [Key(7)]
    public int[] RewardValues { get; set; }
    [Key(8)]
    public RewardType[] RewardTypes { get; set; }
}
