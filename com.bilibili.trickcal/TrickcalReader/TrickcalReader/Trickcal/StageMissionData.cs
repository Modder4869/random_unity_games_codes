using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class StageMissionData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public StageMissionType Type { get; set; }
    [Key(2)]
    public int[] Values { get; set; }
    [Key(3)]
    public string Desc { get; set; }
}
