using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class MinionLevelData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int MinionInfoUid { get; set; }
    [Key(2)]
    public TableBaseStatData Stat { get; set; }
    [Key(3)]
    public int DefaultSp { get; set; }
}
