using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class MinigameVelaFeverData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int Level { get; set; }
    [Key(2)]
    public int PointPercent { get; set; }
    [Key(3)]
    public int NextPoint { get; set; }
    [Key(4)]
    public int SpeedPercent { get; set; }
    [Key(5)]
    public int UnitGroup { get; set; }
}
