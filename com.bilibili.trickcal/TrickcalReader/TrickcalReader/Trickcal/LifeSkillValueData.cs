using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class LifeSkillValueData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int TaskGrade { get; set; }
    [Key(2)]
    public int LifeSkillValue { get; set; }
}
