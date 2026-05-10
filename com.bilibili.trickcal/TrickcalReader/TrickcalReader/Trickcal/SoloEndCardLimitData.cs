using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SoloEndCardLimitData : TableItem<TableData> {
    [Key(0)]
    public int CardUid { get; set; }
    [Key(1)]
    public CardType CardType { get; set; }
    [Key(2)]
    public int LimitCountNormal { get; set; }
    [Key(3)]
    public int LimitCountBoss { get; set; }
}
