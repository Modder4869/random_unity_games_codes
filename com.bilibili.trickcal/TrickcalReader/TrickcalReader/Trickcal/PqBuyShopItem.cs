using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqBuyShopItem {
    [Key(0)]
    public int ShopDataUid { get; set; }
    [Key(1)]
    public int Count { get; set; }
    [Key(2)]
    public int[] ShopDataUids { get; set; }
    [Key(3)]
    public int[] Counts { get; set; }
}
