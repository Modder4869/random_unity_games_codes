using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserChainGiftData {
    [Key(0)]
    public int GiftBatch { get; set; }
    [Key(1)]
    public DateTime BuyGiftTime { get; set; }
}
