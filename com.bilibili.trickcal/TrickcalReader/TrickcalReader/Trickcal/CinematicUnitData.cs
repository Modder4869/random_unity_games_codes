using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class CinematicUnitData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int StageUid { get; set; }
    [Key(2)]
    public MixedEventCinematicUnitType Type { get; set; }
    [Key(3)]
    public string TalkText { get; set; }
    [Key(4)]
    public UnitType[] UnitType { get; set; }
    [Key(5)]
    public int[] UnitUid { get; set; }
    [Key(6)]
    public string[] UnitSkin { get; set; }
    [Key(7)]
    public string[] UnitAni { get; set; }
    [Key(8)]
    public int[] UnitPosX { get; set; }
    [Key(9)]
    public int[] UnitPosY { get; set; }
    [Key(10)]
    public float[] UnitScale { get; set; }
}
