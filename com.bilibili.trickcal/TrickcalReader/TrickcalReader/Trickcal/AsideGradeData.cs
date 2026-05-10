using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class AsideGradeData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int HeroUid { get; set; }
    [Key(2)]
    public int Grade { get; set; }
    [Key(3)]
    public int AsideSkill { get; set; }
    [Key(4)]
    public TableBaseStatData Stat { get; set; }
}
