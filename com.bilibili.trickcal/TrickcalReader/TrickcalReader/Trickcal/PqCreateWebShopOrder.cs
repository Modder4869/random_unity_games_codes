using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqCreateWebShopOrder {
    [Key(0)]
    public string ProductId { get; set; }
    [Key(1)]
    public OsType OsType { get; set; }
    [Key(2)]
    public int Quantity { get; set; }
}
