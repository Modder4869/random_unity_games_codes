using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class CashShopData : TableItem<TableData> {
    [Key(0)]
    public TableBaseShopItemData Data { get; set; }
    [Key(1)]
    public string StoreKeyPlayStore { get; set; }
    [Key(2)]
    public string StoreKeyAppStore { get; set; }
    [Key(3)]
    public int PriceDown { get; set; }
    [Key(4)]
    public int ExOption { get; set; }
}
