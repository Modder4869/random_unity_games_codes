using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SkinSpineUIData : TableItem<TableData> {
    [Key(0)]
    public int SkinUid { get; set; }
    [Key(1)]
    public float StandingOffsetX { get; set; }
    [Key(2)]
    public float StandingOffsetY { get; set; }
    [Key(3)]
    public float StandingScale { get; set; }
}
