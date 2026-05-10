using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class AsideEffectData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int Grade { get; set; }
    [Key(2)]
    public ArtifactTriggerType TriggerType { get; set; }
    [Key(3)]
    public int TriggerValue { get; set; }
    [Key(4)]
    public StatusEffect StatusEffect { get; set; }
    [Key(5)]
    public float StatusEffectValue { get; set; }
    [Key(6)]
    public float StatusEffectDuration { get; set; }
    [Key(7)]
    public TargetGroupType TargetGroup { get; set; }
    [Key(8)]
    public TargetSectionType TargetSection { get; set; }
    [Key(9)]
    public TargetJobType TargetJob { get; set; }
    [Key(10)]
    public TargetPersonalityType TargetPersonality { get; set; }
    [Key(11)]
    public TargetTribeType TargetTribe { get; set; }
    [Key(12)]
    public string EffectAction { get; set; }
    [Key(13)]
    public float[] EffectParam { get; set; }
    [Key(14)]
    public string Name { get; set; }
    [Key(15)]
    public string Desc { get; set; }
    [Key(16)]
    public string Detail { get; set; }
    [Key(17)]
    public string Icon { get; set; }
    [Key(18)]
    public string DetailRule { get; set; }
    [Key(19)]
    public string StatusEffectNewUid { get; set; }
    [Key(20)]
    public double StatusEffectNewDuration { get; set; }
    [Key(21)]
    public double[] StatusEffectNewValues { get; set; }
    [Key(22)]
    public string[] EffectParamNew { get; set; }
    [Key(23)]
    public bool HoldTarget { get; set; }
    [Key(24)]
    public string[] ExtraParam { get; set; }
    [Key(25)]
    public float TriggerProbability { get; set; }
    [Key(26)]
    public int TriggerCount { get; set; }
    [Key(27)]
    public int StartTriggerCount { get; set; }
}
