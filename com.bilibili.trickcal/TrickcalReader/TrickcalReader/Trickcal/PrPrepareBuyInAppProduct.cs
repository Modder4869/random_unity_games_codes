using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrPrepareBuyInAppProduct {
    [Key(0)]
    public string InAppPurchaseKey { get; set; }
    [Key(1)]
    public int CpServerId { get; set; }
    [Key(2)]
    public string CpServerName { get; set; }
    [Key(3)]
    public string OutTradeNo { get; set; }
    [Key(4)]
    public string ProductId { get; set; }
    [Key(5)]
    public string NotifyUrl { get; set; }
    [Key(6)]
    public string ExtensionInfo { get; set; }
    [Key(7)]
    public string OrderSign { get; set; }
    [Key(8)]
    public int Money { get; set; }
    [Key(9)]
    public int GameMoney { get; set; }
}
