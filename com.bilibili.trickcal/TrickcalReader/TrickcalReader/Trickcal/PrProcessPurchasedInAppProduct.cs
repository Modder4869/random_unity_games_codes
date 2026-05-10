using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrProcessPurchasedInAppProduct {
    [Key(0)]
    public int CashShopDataUid { get; set; }
    [Key(1)]
    public bool IsFirstBuy { get; set; }
}
