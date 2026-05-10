using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class AugmentLevelData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int AugmentUid { get; set; }
    [Key(2)]
    public int Tier { get; set; }
    [Key(3)]
    public int Rarity { get; set; }
    [Key(4)]
    public string Desc { get; set; }
    [Key(5)]
    public AugmentCondition Condition { get; set; }
    [Key(6)]
    public float ActiveProbability { get; set; }
    [Key(7)]
    public float CoolTimePerTarget { get; set; }
    [Key(8)]
    public float CoolTime { get; set; }
    [Key(9)]
    public float[] Params { get; set; }
    [Key(10)]
    public string DetailDesc { get; set; }
    [Key(11)]
    public int _00 { get; set; }
    [Key(12)]
    public string AugmentAction { get; set; }
    [Key(13)]
    public string[] ParamsGlobal { get; set; }
    [Key(14)]
    public int FilterType { get; set; }
    [Key(15)]
    public string FilterValue { get; set; }
    [Key(16)]
    public int TriggerCount { get; set; }
    [Key(17)]
    public string ConditionValue { get; set; }
}
