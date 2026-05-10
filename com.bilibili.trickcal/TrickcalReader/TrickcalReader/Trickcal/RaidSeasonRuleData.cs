using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class RaidSeasonRuleData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public string Desc { get; set; }
    [Key(2)]
    public string Icon { get; set; }
    [Key(3)]
    public float[] Param { get; set; }
    [Key(4)]
    public StatusEffect StatusEffectKey { get; set; }
    [Key(5)]
    public SoloEndWorldRuleTargetType SeasonRuleTarget { get; set; }
}
