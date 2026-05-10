using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqNotifyWebShopOrder {
    [Key(0)]
    public string SdkOrderNo { get; set; }
    [Key(1)]
    public string OrderNo { get; set; }
    [Key(2)]
    public OsType OsType { get; set; }
    [Key(3)]
    public OneSdkInfo OneSdkInfo { get; set; }
    [Key(4)]
    public GlobalCurrencyType CurrencyType { get; set; }
    [Key(5)]
    public int Quantity { get; set; }
}
