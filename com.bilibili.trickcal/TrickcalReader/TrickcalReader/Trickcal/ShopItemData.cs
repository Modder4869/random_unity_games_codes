using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ShopItemData : TableItem<TableData> {
    [Key(0)]
    public TableBaseShopItemData Data { get; set; }
}
