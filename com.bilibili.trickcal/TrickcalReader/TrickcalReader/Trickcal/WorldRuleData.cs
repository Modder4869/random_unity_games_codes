using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class WorldRuleData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public string WorldRuleDesc { get; set; }
    [Key(2)]
    public string WorldRuleIcon { get; set; }
    [Key(3)]
    public StatusEffect StatusEffectKey { get; set; }
    [Key(5)]
    public int[] Param { get; set; }
    [Key(6)]
    public TargetGroupType TargetGroup { get; set; }
    [Key(7)]
    public TargetSectionType TargetSection { get; set; }
    [Key(8)]
    public TargetJobType TargetJob { get; set; }
    [Key(9)]
    public TargetPersonalityType TargetPersonality { get; set; }
    [Key(10)]
    public TargetTribeType TargetTribe { get; set; }
    [Key(11)]
    public string StatusEffectKeyNew { get; set; }
    [Key(12)]
    public WorldRuleConditionType ConditionType { get; set; }
    [Key(13)]
    public string ConditionTypeValue { get; set; }
}
