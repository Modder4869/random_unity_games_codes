using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class LifeLevelUpData : TableItem<TableData> {
    [Key(0)]
    public int LifeLevel { get; set; }
    [Key(1)]
    public int NeedExp { get; set; }
    [Key(2)]
    public int LvValue { get; set; }
    [Key(3)]
    public int TaskGrade { get; set; }
    [Key(4)]
    public int RestMin { get; set; }
    [Key(5)]
    public int RestMax { get; set; }
    [Key(6)]
    public int OwnSkillMin { get; set; }
    [Key(7)]
    public int OwnSkillProb { get; set; }
    [Key(8)]
    public int LifeSkillLevelUp { get; set; }
}
