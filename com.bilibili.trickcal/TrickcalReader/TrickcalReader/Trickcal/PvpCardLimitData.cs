using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PvpCardLimitData : TableItem<TableData> {
    [Key(0)]
    public int CardUid { get; set; }
    [Key(1)]
    public CardType CardType { get; set; }
    [Key(2)]
    public int LimitCount { get; set; }
}
