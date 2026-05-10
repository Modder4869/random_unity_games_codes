using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqDailyLotteryEventSelectGroup {
    [Key(0)]
    public int MixedEventUid { get; set; }
    [Key(1)]
    public int DailyLotteryRewardGroupId { get; set; }
}
