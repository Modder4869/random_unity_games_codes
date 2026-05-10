using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class LifeConditionData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public LifeConditionType Type { get; set; }
    [Key(2)]
    public LifeConditionEffectType EffectType { get; set; }
    [Key(4)]
    public int Value { get; set; }
    [Key(5)]
    public string Name { get; set; }
    [Key(6)]
    public string Desc { get; set; }
    [Key(7)]
    public string EffectDesc { get; set; }
    [Key(8)]
    public LifeConditionCategoryType Category { get; set; }
    [Key(9)]
    public string Icon { get; set; }
}
