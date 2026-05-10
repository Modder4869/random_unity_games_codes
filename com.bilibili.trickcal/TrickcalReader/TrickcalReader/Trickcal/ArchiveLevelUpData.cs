using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ArchiveLevelUpData : TableItem<TableData> {
    [Key(0)]
    public int Level { get; set; }
    [Key(1)]
    public TableBaseMyHomeLevelUpNeedData Needs { get; set; }
}
