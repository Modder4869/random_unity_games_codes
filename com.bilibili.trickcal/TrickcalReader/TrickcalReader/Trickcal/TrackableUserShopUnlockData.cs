using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserShopUnlockData {
    [Key(0)]
    public DateTime UnlockTime { get; set; }
    [Key(1)]
    public short BuyCount { get; set; }
}
