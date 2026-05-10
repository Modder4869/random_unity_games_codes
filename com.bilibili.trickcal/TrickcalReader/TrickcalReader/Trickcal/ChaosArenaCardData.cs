using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ChaosArenaCardData : TableItem<TableData> {
    [Key(0)]
    public int CardUid { get; set; }
    [Key(1)]
    public int ChaosArenaInfoUid { get; set; }
    [Key(2)]
    public CardType CardType { get; set; }
    [Key(3)]
    public int LimitCount { get; set; }
}
