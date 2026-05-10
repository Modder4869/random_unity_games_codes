using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqProcessPurchasedInAppProduct {
    [Key(0)]
    public string Payload { get; set; }
}
