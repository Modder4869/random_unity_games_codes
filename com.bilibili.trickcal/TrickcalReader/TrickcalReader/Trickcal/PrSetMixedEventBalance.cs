using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrSetMixedEventBalance {
    [Key(0)]
    public bool IsRewardReceived { get; set; }
}
