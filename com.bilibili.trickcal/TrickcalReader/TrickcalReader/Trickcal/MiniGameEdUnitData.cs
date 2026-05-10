using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class MiniGameEdUnitData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public JobType Job { get; set; }
    [Key(2)]
    public float Scale { get; set; }
    [Key(3)]
    public string SpineBattle { get; set; }
    [Key(4)]
    public string SpineStanding { get; set; }
    [Key(5)]
    public string Name { get; set; }
}
