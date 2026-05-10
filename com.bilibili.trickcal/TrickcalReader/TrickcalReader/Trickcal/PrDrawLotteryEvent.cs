using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrDrawLotteryEvent {
    [Key(0)]
    public int RealDrawCount { get; set; }
}
