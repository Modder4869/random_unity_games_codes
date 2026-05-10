using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqGoNextRoundLotteryEvent {
    [Key(0)]
    public int EventUid { get; set; }
    [Key(1)]
    public int LotteryGroupUid { get; set; }
}
