using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqBuyCashShopItem {
    [Key(0)]
    public int ShopDataUid { get; set; }
    [Key(1)]
    public int Count { get; set; }
}
