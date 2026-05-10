using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class StatusEffectDataNew : TableItem<TableData> {
    [Key(0)]
    public string Uid { get; set; }
    [Key(1)]
    public string[] SubTypeUids { get; set; }
    [Key(2)]
    public ApplyTypeNew ApplyType { get; set; }
    [Key(3)]
    public ApplySubType ApplySubType { get; set; }
    [Key(4)]
    public bool Removable { get; set; }
    [Key(5)]
    public OverlapType StackType { get; set; }
    [Key(6)]
    public int StackCount { get; set; }
    [Key(7)]
    public GlobalStackExclusiveType StackExclusiveType { get; set; }
    [Key(8)]
    public TargetSectionType ConditionSectionType { get; set; }
    [Key(9)]
    public TargetJobType ConditionJobType { get; set; }
    [Key(10)]
    public TargetPersonalityType ConditionPersonalityType { get; set; }
    [Key(11)]
    public TargetTribeType ConditionTribeType { get; set; }
    [Key(12)]
    public TargetSkillType ConditionSkillType { get; set; }
    [Key(13)]
    public TargetDamageType ConditionDamageType { get; set; }
    [Key(14)]
    public TargetUnitType ConditionUnitType { get; set; }
    [Key(15)]
    public PostSkillEffectActiveType PostSkillEffectActiveType { get; set; }
    [Key(16)]
    public int PostSkillEffectActiveValue { get; set; }
    [Key(17)]
    public string PostSkillEffectUid { get; set; }
    [Key(18)]
    public string Name { get; set; }
    [Key(19)]
    public string Desc { get; set; }
    [Key(20)]
    public string Icon { get; set; }
    [Key(21)]
    public ArtifactTriggerType TriggerType { get; set; }
    [Key(22)]
    public ArtifactTriggerConditionType TriggerConditionType { get; set; }
    [Key(23)]
    public string TriggerConditionValue { get; set; }
    [Key(24)]
    public string TriggerTypeValue { get; set; }
    [Key(25)]
    public StatusEffectConditionType ConditionType { get; set; }
    [Key(26)]
    public string ConditionTypeValue { get; set; }
    [Key(27)]
    public SkillType PostSkillType { get; set; }
    [Key(28)]
    public ArtifactTriggerType ReleaseTriggerType { get; set; }
    [Key(29)]
    public string ReleaseTriggerValue { get; set; }
}
