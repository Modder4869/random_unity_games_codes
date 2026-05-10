using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class LifeSkillGroupData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int LifeSkillDefault { get; set; }
    [Key(2)]
    public int[] LifeSkills { get; set; }
}
