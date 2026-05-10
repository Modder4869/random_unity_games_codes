using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqDrawLotteryEvent {
    [Key(0)]
    public int EventUid { get; set; }
    [Key(1)]
    public int LotteryGroupUid { get; set; }
    [Key(2)]
    public int DrawCount { get; set; }
}
