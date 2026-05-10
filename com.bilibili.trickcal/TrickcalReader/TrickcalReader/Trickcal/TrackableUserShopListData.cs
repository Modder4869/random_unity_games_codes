using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserShopListData {
    [Key(0)]
    public int[] Items { get; set; }
    [Key(1)]
    public int[] ItemCounts { get; set; }
    [Key(2)]
    public int[] ItemBuyCounts { get; set; }
    [Key(3)]
    public int[] PriceItems { get; set; }
    [Key(4)]
    public int[] PriceCounts { get; set; }
    [Key(5)]
    public short ItemsRefreshCount { get; set; }
}
