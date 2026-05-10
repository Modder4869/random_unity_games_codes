using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class EventBridgePageUIData : TableItem<TableData> {
    [Key(0)]
    public int GroupUid { get; set; }
    [Key(1)]
    public int ContentUid { get; set; }
    [Key(2)]
    public BridgeContentType Type { get; set; }
    [Key(3)]
    public float IconX { get; set; }
    [Key(4)]
    public float IconY { get; set; }
    [Key(5)]
    public float IconScale { get; set; }
    [Key(6)]
    public string Icon { get; set; }
    [Key(7)]
    public string IconName { get; set; }
    [Key(8)]
    public string BaseColor { get; set; }
    [Key(9)]
    public string IconNameBG { get; set; }
    [Key(10)]
    public string TagColor { get; set; }
    [Key(11)]
    public string TagName { get; set; }
}
