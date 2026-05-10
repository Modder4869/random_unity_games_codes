using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrGetScoreEventInfo {
    [Key(0)]
    public long Score { get; set; }
}
