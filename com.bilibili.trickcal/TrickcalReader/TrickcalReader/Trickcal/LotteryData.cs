using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class LotteryData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int GroupUid { get; set; }
    [Key(2)]
    public int Round { get; set; }
    [Key(3)]
    public int Sort { get; set; }
    [Key(4)]
    public int RewardUid { get; set; }
    [Key(5)]
    public int RewardCount { get; set; }
    [Key(6)]
    public int RewardLimitCount { get; set; }
    [Key(7)]
    public int Rate { get; set; }
    [Key(8)]
    public bool IsMain { get; set; }
}
