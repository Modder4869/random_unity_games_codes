using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrDailyLotteryEventReceiveReward {
    [Key(0)]
    public int? RewardGrade { get; set; }
}
