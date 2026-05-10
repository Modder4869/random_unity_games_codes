using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ScenarioTextData : TableItem<TableData> {
    [Key(0)]
    public string Uid { get; set; }
    [Key(1)]
    public string Kr { get; set; }
    [Key(2)]
    public string En { get; set; }
    [Key(3)]
    public string Jp { get; set; }
    [Key(4)]
    public string ZhChs { get; set; }
    [Key(5)]
    public string ZhCht { get; set; }
}
