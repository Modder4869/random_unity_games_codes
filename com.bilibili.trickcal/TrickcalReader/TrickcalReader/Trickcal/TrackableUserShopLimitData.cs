using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserShopLimitData {
    [Key(0)]
    public int LimitValue { get; set; }
    [Key(1)]
    public DateTime StartTime { get; set; }
}
