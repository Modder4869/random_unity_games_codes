using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqDailyLotteryEventDismissHallOfFame {
    [Key(0)]
    public int MixedEventUid { get; set; }
    [Key(1)]
    public int Day { get; set; }
}
