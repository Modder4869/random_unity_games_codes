using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqReceiveShopFlatReward {
    [Key(0)]
    public int ShopItemUid { get; set; }
}
