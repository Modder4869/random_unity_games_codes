using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqReceiveShopPackageCheckReward {
    [Key(0)]
    public int ShopDataUid { get; set; }
}
