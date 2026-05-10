using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SignatureSpellCardData : TableItem<TableData> {
    [Key(0)]
    public int SignatureCardUid { get; set; }
    [Key(1)]
    public int ConditionLv { get; set; }
    [Key(2)]
    public string Action { get; set; }
    [Key(3)]
    public int[] ActionParam { get; set; }
    [Key(5)]
    public int[] StatusTargetConditionValue { get; set; }
    [Key(6)]
    public StatusEffect[] StatusEffectType { get; set; }
    [Key(7)]
    public int[] StatusEffectValue { get; set; }
    [Key(8)]
    public string EffectDesc { get; set; }
    [Key(9)]
    public string StatusEffectTypeNew { get; set; }
    [Key(11)]
    public string[] ActionParamNew { get; set; }
    [Key(12)]
    public string[] StatusEffectValueNew { get; set; }
    [Key(13)]
    public TargetGroupType TargetGroup { get; set; }
    [Key(14)]
    public StatusEffectConditionType TargetCondition { get; set; }
    [Key(15)]
    public string TargetConditionValue { get; set; }
    [Key(16)]
    public TargetSectionType TargetSection { get; set; }
    [Key(17)]
    public TargetJobType TargetJob { get; set; }
    [Key(18)]
    public TargetPersonalityType TargetPersonality { get; set; }
    [Key(19)]
    public TargetTribeType TargetTribe { get; set; }
    [Key(20)]
    public TargetDamageType TargetDamageType { get; set; }
    [Key(21)]
    public TargetUnitType TargetUnitType { get; set; }
    [Key(22)]
    public TargetSkillType TargetSkillType { get; set; }
    [Key(24)]
    public string ActionEffectDetail { get; set; }
    [Key(25)]
    public string StatusEffectDetail { get; set; }
}
