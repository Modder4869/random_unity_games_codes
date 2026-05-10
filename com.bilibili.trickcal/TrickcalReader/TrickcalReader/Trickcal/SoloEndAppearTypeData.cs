using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SoloEndAppearTypeData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public SoloEndAppearType SoloEndAppearType { get; set; }
    [Key(2)]
    public int AppearRatio { get; set; }
    [Key(3)]
    public bool IsReadyState { get; set; }
}
