using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class MinigameVelaUnitGroupData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int Group { get; set; }
    [Key(2)]
    public VelaMinigameUnitType UnitType { get; set; }
    [Key(3)]
    public int AppearRate { get; set; }
    [Key(4)]
    public int AppearPoint { get; set; }
    [Key(5)]
    public int AppearFeverGauge { get; set; }
    [Key(6)]
    public int DisappearPoint { get; set; }
    [Key(7)]
    public int DisappearFeverGauge { get; set; }
    [Key(8)]
    public int HitPoint { get; set; }
    [Key(9)]
    public int HitFeverGauge { get; set; }
    [Key(10)]
    public int KillPoint { get; set; }
    [Key(11)]
    public int KillFeverGauge { get; set; }
}
