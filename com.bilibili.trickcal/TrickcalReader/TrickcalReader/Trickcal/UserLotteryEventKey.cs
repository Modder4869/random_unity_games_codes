using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public struct UserLotteryEventKey {
    [Key(0)]
    public int EventUid { get; set; }
    [Key(1)]
    public int LotteryEventUid { get; set; }
}
