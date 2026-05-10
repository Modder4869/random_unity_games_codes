using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class UserSkillGrowthLevelData : TableItem<TableData> {
    [Key(0)]
    public int GroupUid { get; set; }
    [Key(1)]
    public int Uid { get; set; }
    [Key(2)]
    public int Level { get; set; }
    [Key(3)]
    public UserSkillTriggerType TriggerType { get; set; }
    [Key(4)]
    public string TriggerValue { get; set; }
    [Key(5)]
    public UserSkillGrowthType ActionType { get; set; }
    [Key(6)]
    public float Probability { get; set; }
    [Key(7)]
    public string[] Params { get; set; }
}
