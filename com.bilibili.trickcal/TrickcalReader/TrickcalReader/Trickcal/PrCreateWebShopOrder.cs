using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrCreateWebShopOrder {
    [Key(0)]
    public CreateOrderResData CreateOrderResData { get; set; }
}
