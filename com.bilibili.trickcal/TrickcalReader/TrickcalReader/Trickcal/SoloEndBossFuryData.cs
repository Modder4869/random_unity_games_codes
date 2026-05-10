using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SoloEndBossFuryData : TableItem<TableData> {
    [Key(0)]
    public int OverDeathCount { get; set; }
    [Key(1)]
    public StatusEffect StatusEffectKey { get; set; }
    [Key(2)]
    public float Param { get; set; }
}
