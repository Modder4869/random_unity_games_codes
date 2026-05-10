using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class HeroGradeData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int HeroInfoUid { get; set; }
    [Key(2)]
    public int Grade { get; set; }
    [Key(3)]
    public TableBaseStatData Stat { get; set; }
}
