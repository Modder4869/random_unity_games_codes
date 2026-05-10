using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqRefreshShopItems {
    [Key(0)]
    public int ShopSubCategoryId { get; set; }
}
