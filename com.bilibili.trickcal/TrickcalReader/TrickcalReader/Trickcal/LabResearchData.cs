using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class LabResearchData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int Step { get; set; }
    [Key(2)]
    public int Order { get; set; }
    [Key(3)]
    public LabEffectTableType TableEffectType { get; set; }
    [Key(4)]
    public int Value { get; set; }
    [Key(5)]
    public int TimeSeconds { get; set; }
    [Key(6)]
    public int[] NeedItem { get; set; }
    [Key(7)]
    public int[] NeedValue { get; set; }
    [Key(8)]
    public string Desc { get; set; }
    [Key(9)]
    public string Icon { get; set; }
    [Key(10)]
    public int NeedGold { get; set; }
    [Key(11)]
    public LabEffectCondition LabEffectCondition { get; set; }
}
