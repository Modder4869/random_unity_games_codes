using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class MinigameVelaSpeedData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int Group { get; set; }
    [Key(2)]
    public int Level { get; set; }
    [Key(3)]
    public int Duration { get; set; }
    [Key(4)]
    public float AppearFrequency { get; set; }
    [Key(5)]
    public float DisappearDuration { get; set; }
    [Key(6)]
    public int UnitGroup { get; set; }
    [Key(7)]
    public int[] UnitRatio { get; set; }
}
