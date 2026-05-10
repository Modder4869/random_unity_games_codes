using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SkillNewData : TableItem<TableData> {
    [Key(0)]
    public int UnitUid { get; set; }
    [Key(1)]
    public int SkillUid { get; set; }
    [Key(2)]
    public SkillType SkillType { get; set; }
    [Key(3)]
    public SpecialCondition SpecialCondition { get; set; }
    [Key(4)]
    public string SpecialValue { get; set; }
    [Key(5)]
    public int SpecialProb { get; set; }
    [Key(6)]
    public SkillConditionType ConditionType { get; set; }
    [Key(7)]
    public string ConditionValue { get; set; }
    [Key(8)]
    public Target TargetType { get; set; }
    [Key(9)]
    public SpecialMoveType SpecialMoveType { get; set; }
    [Key(10)]
    public float TargetRange { get; set; }
    [Key(11)]
    public float SkillRangeMin { get; set; }
    [Key(12)]
    public float SkillRangeMax { get; set; }
    [Key(13)]
    public float CoolTime { get; set; }
    [Key(14)]
    public float FirstCoolTime { get; set; }
    [Key(15)]
    public string Name { get; set; }
    [Key(16)]
    public string Desc { get; set; }
    [Key(17)]
    public string Detail { get; set; }
    [Key(18)]
    public string Icon { get; set; }
    [Key(19)]
    public string PreviewActive { get; set; }
    [Key(20)]
    public RecommendCore RecommendCore1 { get; set; }
    [Key(21)]
    public RecommendCore RecommendCore2 { get; set; }
    [Key(22)]
    public bool PVPBalance { get; set; }
    [Key(23)]
    public bool IsSignatureCardSkill { get; set; }
    [Key(24)]
    public TargetGroupType TargetGroup { get; set; }
    [Key(25)]
    public TargetConditionType TargetCondition { get; set; }
    [Key(26)]
    public float TargetConditionValue { get; set; }
    [Key(27)]
    public TargetSectionType TargetSection { get; set; }
    [Key(28)]
    public TargetJobType TargetJob { get; set; }
    [Key(29)]
    public TargetPersonalityType TargetPersonality { get; set; }
    [Key(30)]
    public TargetTribeType TargetTribe { get; set; }
    [Key(31)]
    public string SkillSwapCondition { get; set; }
    [Key(32)]
    public string SkillSwapValue { get; set; }
    [Key(33)]
    public bool IsGlobalPassive { get; set; }
    [Key(34)]
    public TargetConditionType TargetIgnoreCondition { get; set; }
    [Key(35)]
    public float TargetIgnoreConditionValue { get; set; }
}
