using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class DailyLotteryEventRewardGroup : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int GroupId { get; set; }
    [Key(2)]
    public DailyLotteryGroupType GroupType { get; set; }
    [Key(3)]
    public DailyLotteryType LotteryType { get; set; }
    [Key(4)]
    public int LotteryValue { get; set; }
    [Key(5)]
    public short RewardGrade { get; set; }
    [Key(6)]
    public RewardType[] RewardTypes { get; set; }
    [Key(7)]
    public int[] RewardUids { get; set; }
    [Key(8)]
    public int[] RewardValues { get; set; }
}
