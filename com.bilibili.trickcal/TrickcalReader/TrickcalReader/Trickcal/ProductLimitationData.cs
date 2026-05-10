using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ProductLimitationData {
    [Key(0)]
    public string ProductId { get; set; }
    [Key(1)]
    public bool Available { get; set; }
    [Key(2)]
    public int PurchasedTime { get; set; }
    [Key(3)]
    public string Message { get; set; }
}
