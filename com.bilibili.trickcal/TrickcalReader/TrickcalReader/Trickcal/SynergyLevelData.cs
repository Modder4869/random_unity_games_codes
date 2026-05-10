using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SynergyLevelData : TableItem<TableData> {
    [Key(0)]
    public int SynergyUid { get; set; }
    [Key(1)]
    public int Level { get; set; }
    [Key(2)]
    public int HeroCount { get; set; }
    [Key(3)]
    public string SynergyAction { get; set; }
    [Key(4)]
    public SynergyTarget[] EffectTargets { get; set; }
    [Key(5)]
    public StatusEffect[] EffectTypes { get; set; }
    [Key(6)]
    public float[] EffectValues { get; set; }
    [Key(7)]
    public string Desc { get; set; }
    [Key(8)]
    public string DescDetail { get; set; }
    [Key(9)]
    public string[] GlobalEffectTypes { get; set; }
}
