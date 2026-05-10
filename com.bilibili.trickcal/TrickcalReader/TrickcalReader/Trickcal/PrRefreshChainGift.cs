using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrRefreshChainGift {
    [Key(0)]
    public int CurrentBatch { get; set; }
    [Key(1)]
    public int NextBatch { get; set; }
}
