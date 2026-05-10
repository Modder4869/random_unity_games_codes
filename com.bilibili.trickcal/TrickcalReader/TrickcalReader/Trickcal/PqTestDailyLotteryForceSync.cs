using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestDailyLotteryForceSync {
    [Key(0)]
    public int MixedEventUid { get; set; }
}
