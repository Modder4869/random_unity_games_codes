using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ExtraAppearData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public ExtraAppearPlaceType Place { get; set; }
    [Key(2)]
    public int LookDirection { get; set; }
    [Key(3)]
    public string Text { get; set; }
    [Key(4)]
    public string StartAni { get; set; }
    [Key(5)]
    public string EndAni { get; set; }
}
