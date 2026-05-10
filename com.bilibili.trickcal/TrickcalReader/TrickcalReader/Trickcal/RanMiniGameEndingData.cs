using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class RanMiniGameEndingData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int MinScore { get; set; }
    [Key(2)]
    public int MaxScore { get; set; }
    [Key(3)]
    public int Unit { get; set; }
    [Key(4)]
    public string Motion { get; set; }
    [Key(5)]
    public string Text { get; set; }
}
