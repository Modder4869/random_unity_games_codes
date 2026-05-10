using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SignatureCardData : TableItem<TableData> {
    [Key(0)]
    public int SignatureCardUid { get; set; }
    [Key(1)]
    public int ConditionLv { get; set; }
    [Key(2)]
    public SignatureEffectType[] EffectType { get; set; }
    [Key(3)]
    public int[] EffectValue { get; set; }
    [Key(4)]
    public string[] EffectStringValue { get; set; }
    [Key(5)]
    public SignatureEmphasisType[] EmphasisType { get; set; }
    [Key(6)]
    public string EffectDesc { get; set; }
    [Key(7)]
    public string[] ParamTypeNew { get; set; }
    [Key(8)]
    public bool[] IgnoreTooltipText { get; set; }
}
