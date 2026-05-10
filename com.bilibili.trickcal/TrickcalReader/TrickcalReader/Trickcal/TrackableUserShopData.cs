using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserShopData {
    [Key(0)]
    public int[] FirstBonusItems { get; set; }
    [Key(1)]
    public int[] DailyCardGachaIds { get; set; }
    [Key(2)]
    public int[] DailyCards { get; set; }
    [Key(3)]
    public int[] DailyCardCostUids { get; set; }
    [Key(4)]
    public short[] DailyCardCounts { get; set; }
    [Key(5)]
    public int[] DailyCardPrices { get; set; }
    [Key(6)]
    public short DailyStaminaRefillCount { get; set; }
    [Key(7)]
    public short DailyModeStaminaRefillCount { get; set; }
    [Key(8)]
    public int[] CheckedPackageItems { get; set; }
}
