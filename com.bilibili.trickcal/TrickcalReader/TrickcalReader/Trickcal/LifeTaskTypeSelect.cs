using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class LifeTaskTypeSelect : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int Type { get; set; }
    [Key(2)]
    public int Weight { get; set; }
}
