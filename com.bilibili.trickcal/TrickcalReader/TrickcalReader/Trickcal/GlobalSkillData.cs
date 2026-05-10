using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class GlobalSkillData : TableItem<TableData> {
    [Key(0)]
    public string Uid { get; set; }
    [Key(1)]
    public int UnitUid { get; set; }
    [Key(2)]
    public SkillType SkillType { get; set; }
    [Key(3)]
    public SkillConditionType[] SkillConditionTypes { get; set; }
    [Key(4)]
    public double[] SkillConditionValues { get; set; }
    [Key(5)]
    public string StartAniName { get; set; }
    [Key(6)]
    public string AniName { get; set; }
    [Key(7)]
    public string EndAniName { get; set; }
    [Key(8)]
    public TargetGroupType MoveTargetGroup { get; set; }
    [Key(9)]
    public TargetConditionType MoveTargetCondition { get; set; }
    [Key(10)]
    public double MoveTargetConditionValue { get; set; }
    [Key(11)]
    public TargetSectionType TargetSection { get; set; }
    [Key(12)]
    public TargetJobType TargetJob { get; set; }
    [Key(13)]
    public TargetPersonalityType TargetPersonality { get; set; }
    [Key(14)]
    public TargetTribeType TargetTribe { get; set; }
    [Key(15)]
    public double TargetRange { get; set; }
    [Key(16)]
    public double FirstCoolTime { get; set; }
    [Key(17)]
    public bool Straight { get; set; }
    [Key(18)]
    public string[] EventUids { get; set; }
    [Key(19)]
    public string Name { get; set; }
    [Key(20)]
    public string Desc { get; set; }
    [Key(21)]
    public string Detail { get; set; }
    [Key(22)]
    public string Icon { get; set; }
    [Key(23)]
    public string PreviewActive { get; set; }
    [Key(24)]
    public RecommendCore[] RecommendCores { get; set; }
    [Key(25)]
    public bool IsSignatureCardSkill { get; set; }
    [Key(26)]
    public double SkillRange { get; set; }
    [Key(27)]
    public bool IsGlobalPassive { get; set; }
}
