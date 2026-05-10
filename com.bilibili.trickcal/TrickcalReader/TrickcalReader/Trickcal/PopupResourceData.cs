using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PopupResourceData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public string Title { get; set; }
    [Key(2)]
    public string BackGround { get; set; }
    [Key(3)]
    public string OutBorderColor { get; set; }
    [Key(4)]
    public string InBorderColor { get; set; }
    [Key(5)]
    public string SpineShadow { get; set; }
    [Key(6)]
    public string UnderBGColor { get; set; }
}
