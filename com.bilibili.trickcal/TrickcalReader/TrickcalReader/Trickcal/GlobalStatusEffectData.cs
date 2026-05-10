using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class GlobalStatusEffectData : TableItem<TableData> {
    [Key(0)]
    public string Uid { get; set; }
    [Key(1)]
    public GlobalStatusEffectType StatusEffectType { get; set; }
    [Key(2)]
    public GlobalStatusEffectCaster StatusEffectCaster { get; set; }
    [Key(3)]
    public GlobalStatusEffectTarget StatusEffectTarget { get; set; }
    [Key(4)]
    public GlobalStatusEffectApplyType ApplyType { get; set; }
    [Key(5)]
    public double Duration { get; set; }
    [Key(6)]
    public bool Removable { get; set; }
    [Key(7)]
    public OverlapType StackType { get; set; }
    [Key(8)]
    public double StackValue { get; set; }
    [Key(9)]
    public GlobalStackExclusiveType StackExclusiveType { get; set; }
    [Key(10)]
    public string[] Params { get; set; }
    [Key(11)]
    public string[] ObjectUids { get; set; }
    [Key(12)]
    public string[] PostSkillActionUids { get; set; }
    [Key(13)]
    public string[] AdditionalStatusEffectUids { get; set; }
    [Key(14)]
    public string Icon { get; set; }
    [Key(15)]
    public TargetSectionType ConditionTargetSection { get; set; }
    [Key(16)]
    public TargetJobType ConditionTargetJob { get; set; }
    [Key(17)]
    public TargetPersonalityType ConditionTargetPersonality { get; set; }
    [Key(18)]
    public TargetTribeType ConditionTargetTribe { get; set; }
    [Key(19)]
    public GlobalTargetSkillType ConditionTargetSkillType { get; set; }
}
