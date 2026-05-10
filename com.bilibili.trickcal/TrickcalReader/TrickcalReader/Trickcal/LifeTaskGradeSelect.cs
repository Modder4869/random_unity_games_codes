using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class LifeTaskGradeSelect : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public LifeTaskType Type { get; set; }
    [Key(2)]
    public int TaskGradeGap { get; set; }
    [Key(3)]
    public int Weight { get; set; }
}
