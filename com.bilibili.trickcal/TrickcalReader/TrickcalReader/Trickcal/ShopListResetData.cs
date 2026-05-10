using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ShopListResetData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int NeedItemUid { get; set; }
    [Key(2)]
    public int Price { get; set; }
}
