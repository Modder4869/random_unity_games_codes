using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ChaosArenaNormalRuleData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int NormalRuleGroupUid { get; set; }
    [Key(2)]
    public int RuleInfoGroupUid { get; set; }
    [Key(3)]
    public TargetGroupType TargetGroup { get; set; }
    [Key(4)]
    public TargetGradeType TargetGrade { get; set; }
    [Key(5)]
    public string RuleType { get; set; }
    [Key(6)]
    public string RuleKey { get; set; }
    [Key(7)]
    public string[] Param { get; set; }
}
