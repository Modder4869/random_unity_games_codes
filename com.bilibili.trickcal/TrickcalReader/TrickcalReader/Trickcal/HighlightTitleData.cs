using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class HighlightTitleData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int Group { get; set; }
    [Key(2)]
    public int Weight { get; set; }
    [Key(3)]
    public string Spine { get; set; }
    [Key(4)]
    public string Text { get; set; }
    [Key(5)]
    public string TextColor { get; set; }
    [Key(6)]
    public string TextBorderColor { get; set; }
    [Key(7)]
    public int InteractionGroup { get; set; }
}
