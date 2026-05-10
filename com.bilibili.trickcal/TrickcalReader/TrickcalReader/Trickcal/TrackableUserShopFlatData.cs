using MessagePack;
using System.Collections;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserShopFlatData {
    [Key(0)]
    public int LastReceivedDayIndex { get; set; }
    [Key(1)]
    public DateTime LastReceivedTime { get; set; }
    [Key(2)]
    public DateTime StartTime { get; set; }
    [Key(3)]
    public BitArray ReceivedDays { get; set; }
    [Key(4)]
    public int NextPurchaseCount { get; set; }
}
