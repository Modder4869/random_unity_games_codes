using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class MiniGameDianaYesterEnding : TableItem<TableData> {
    [Key(1)]
    public int Uid { get; set; }
    [Key(2)]
    public int Unit { get; set; }
    [Key(3)]
    public string Animation { get; set; }
    [Key(4)]
    public string Dialogue { get; set; }
}
