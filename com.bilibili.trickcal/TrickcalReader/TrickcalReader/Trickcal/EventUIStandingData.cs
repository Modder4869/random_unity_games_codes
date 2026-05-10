using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class EventUIStandingData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int GroupUid { get; set; }
    [Key(2)]
    public UnitType UnitType { get; set; }
    [Key(3)]
    public int UnitUid { get; set; }
    [Key(4)]
    public string Skin { get; set; }
    [Key(5)]
    public bool Flip { get; set; }
    [Key(6)]
    public float PosX { get; set; }
    [Key(7)]
    public float PosY { get; set; }
    [Key(8)]
    public float Scale { get; set; }
    [Key(9)]
    public string UnitStartAni { get; set; }
    [Key(10)]
    public string UnitLoopAni { get; set; }
}
