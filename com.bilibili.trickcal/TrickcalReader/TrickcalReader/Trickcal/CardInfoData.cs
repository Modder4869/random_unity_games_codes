using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class CardInfoData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public CardType Type { get; set; }
    [Key(2)]
    public int Rarity { get; set; }
    [Key(3)]
    public int LimitNum { get; set; }
    [Key(4)]
    public int Sale { get; set; }
    [Key(5)]
    public string Name { get; set; }
    [Key(6)]
    public string Desc { get; set; }
    [Key(7)]
    public string Icon { get; set; }
    [Key(8)]
    public TableBaseItemData ItemData { get; set; }
    [Key(9)]
    public bool IsStory { get; set; }
}
