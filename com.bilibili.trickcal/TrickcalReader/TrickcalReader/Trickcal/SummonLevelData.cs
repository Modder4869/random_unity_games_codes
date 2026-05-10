using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SummonLevelData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int SummonInfoUid { get; set; }
    [Key(2)]
    public TableBaseStatData Stat { get; set; }
}
