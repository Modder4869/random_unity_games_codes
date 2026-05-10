using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class UserSkillInfoData : TableItem<TableData> {
    [Key(0)]
    public int GroupUid { get; set; }
    [Key(1)]
    public int Uid { get; set; }
    [Key(2)]
    public int SkillUid { get; set; }
    [Key(3)]
    public float CoolTime { get; set; }
    [Key(4)]
    public float Cost { get; set; }
    [Key(5)]
    public int Level { get; set; }
    [Key(6)]
    public UserSkillAvailableConditionType AvailableCondition { get; set; }
    [Key(7)]
    public string AvailableValue { get; set; }
    [Key(8)]
    public float FirstCoolTime { get; set; }
}
