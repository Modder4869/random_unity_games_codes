using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ScoreEventRewardData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int Group { get; set; }
    [Key(2)]
    public int Step { get; set; }
    [Key(3)]
    public int NeedScore { get; set; }
    [Key(4)]
    public RewardType[] RewardTypes { get; set; }
    [Key(5)]
    public int[] RewardUids { get; set; }
    [Key(6)]
    public int[] RewardValues { get; set; }
}
