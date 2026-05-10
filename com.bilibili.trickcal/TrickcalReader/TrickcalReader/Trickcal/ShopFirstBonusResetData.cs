using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ShopFirstBonusResetData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int CashShopUid { get; set; }
}
