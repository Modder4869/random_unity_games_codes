using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class DropEventData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(2)]
    public int ShopMainCategory { get; set; }
    [Key(3)]
    public int EventGoodsUid { get; set; }
    [Key(4)]
    public int DropGroup { get; set; }
    [Key(5)]
    public bool IsVisibleInShop { get; set; }
    [Key(6)]
    public ContentsType[] ContentsTypes { get; set; }
    [Key(7)]
    public int MixedEventUid { get; set; }
    [Key(8)]
    public ContentsType[] ExtraTopUIs { get; set; }
    [Key(9)]
    public int NeedItemUid { get; set; }
    [Key(10)]
    public int NeedItemValue { get; set; }
}
