using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrGetProductLimitation {
    [Key(0)]
    public List<ProductLimitationData> ProductLimitationList { get; set; }
}
