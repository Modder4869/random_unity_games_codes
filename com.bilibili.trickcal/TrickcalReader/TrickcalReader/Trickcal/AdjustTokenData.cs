using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class AdjustTokenData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public TokenEventType EventType { get; set; }
    [Key(2)]
    public int CheckKey { get; set; }
    [Key(3)]
    public string TokenCode { get; set; }
}
