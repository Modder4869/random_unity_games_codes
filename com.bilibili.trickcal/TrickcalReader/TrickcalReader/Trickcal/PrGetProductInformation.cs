using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrGetProductInformation {
    [Key(0)]
    public List<ProductInformationData> ProductInformationList { get; set; }
}
