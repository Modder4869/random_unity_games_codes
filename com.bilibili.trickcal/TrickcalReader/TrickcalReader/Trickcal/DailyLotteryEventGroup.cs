using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class DailyLotteryEventGroup : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int GroupId { get; set; }
    [Key(2)]
    public int Day { get; set; }
    [Key(3)]
    public int[] RewardGroup { get; set; }
    [Key(4)]
    public string[] RewardGroupName { get; set; }
    [Key(5)]
    public int DefaultRewardGroup { get; set; }
}
