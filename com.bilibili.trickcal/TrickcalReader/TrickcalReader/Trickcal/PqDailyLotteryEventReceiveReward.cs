using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqDailyLotteryEventReceiveReward {
    [Key(0)]
    public int MixedEventUid { get; set; }
}
