using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqPrepareBuyInAppProduct {
    [Key(0)]
    public int CashShopDataUid { get; set; }
    [Key(1)]
    public StoreType StoreType { get; set; }
    [Key(2)]
    public OsType OsType { get; set; }
    [Key(3)]
    public GlobalCurrencyType CurrencyType { get; set; }
}
