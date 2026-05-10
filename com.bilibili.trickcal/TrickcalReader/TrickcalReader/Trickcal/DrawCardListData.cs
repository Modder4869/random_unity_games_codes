using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class DrawCardListData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public CardType Type { get; set; }
    [Key(2)]
    public int CardId { get; set; }
    [Key(3)]
    public int Weight { get; set; }
    [Key(4)]
    public DrawConditionType DrawConditionType { get; set; }
    [Key(5)]
    public int Param1 { get; set; }
}
