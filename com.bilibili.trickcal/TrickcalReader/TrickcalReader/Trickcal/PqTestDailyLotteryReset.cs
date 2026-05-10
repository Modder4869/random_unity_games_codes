using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestDailyLotteryReset {
    [Key(0)]
    public int MixedEventUid { get; set; }
}
