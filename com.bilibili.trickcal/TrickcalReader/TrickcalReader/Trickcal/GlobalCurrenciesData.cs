using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class GlobalCurrenciesData : TableItem<TableData> {
    [Key(0)]
    public int OriginalKRWAmount { get; set; }
    [Key(1)]
    public int JPYAmount { get; set; }
    [Key(2)]
    public int USDAmount { get; set; }
    [Key(3)]
    public int TWDAmount { get; set; }
    [Key(4)]
    public int HKDAmount { get; set; }
    [Key(5)]
    public int CNYAmount { get; set; }
    [Key(6)]
    public int KRWAmount { get; set; }
    [Key(7)]
    public int RechargePoint { get; set; }
    [Key(8)]
    public int EURAmount { get; set; }
    [Key(9)]
    public int GBPAmount { get; set; }
    [Key(10)]
    public string StoreKeyPlayStore { get; set; }
    [Key(11)]
    public string StoreKeyAppStore { get; set; }
    [Key(12)]
    public int PaymentRefund { get; set; }
}
