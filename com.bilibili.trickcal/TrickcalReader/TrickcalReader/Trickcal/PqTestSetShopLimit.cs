using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestSetShopLimit {
    [Key(0)]
    public int ShopId { get; set; }
    [Key(1)]
    public int Count { get; set; }
    [Key(2)]
    public bool IsRemove { get; set; }
}
