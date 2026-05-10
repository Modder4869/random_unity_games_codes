using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqBuyInAppProduct {
    [Key(0)]
    public string InAppPurchaseKey { get; set; }
    [Key(1)]
    public string Payload { get; set; }
    [Key(2)]
    public string SdkOrderNo { get; set; }
    [Key(3)]
    public string OrderNo { get; set; }
    [Key(4)]
    public OsType OsType { get; set; }
    [Key(5)]
    public OneSdkInfo OneSdkInfo { get; set; }
    [Key(6)]
    public GlobalCurrencyType CurrencyType { get; set; }
}
