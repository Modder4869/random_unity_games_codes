using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class CookingTycoonToastMessageData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int ContentsUid { get; set; }
    [Key(2)]
    public string Text { get; set; }
    [Key(3)]
    public string Ani { get; set; }
    [Key(4)]
    public float PosX { get; set; }
}
