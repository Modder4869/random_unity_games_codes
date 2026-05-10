using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ShopExchangeIDCardData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public string Name { get; set; }
    [Key(2)]
    public NeedItemType NeedItemType { get; set; }
    [Key(3)]
    public int NeedItemUid { get; set; }
    [Key(4)]
    public int PriceOriginal { get; set; }
    [Key(5)]
    public int ProductUid { get; set; }
    [Key(6)]
    public int PurchaseCountMin { get; set; }
    [Key(7)]
    public int PurchaseCountMax { get; set; }
    [Key(8)]
    public int UnlockValue { get; set; }
    [Key(9)]
    public string Desc { get; set; }
    [Key(10)]
    public string Icon { get; set; }
}
