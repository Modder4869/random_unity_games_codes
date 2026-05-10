using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class DialogueBubbleData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int BubbleX { get; set; }
    [Key(2)]
    public int BubbleY { get; set; }
}
