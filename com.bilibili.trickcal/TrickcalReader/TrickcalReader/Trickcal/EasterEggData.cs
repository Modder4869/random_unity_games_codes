using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class EasterEggData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int HeroUid { get; set; }
    [Key(2)]
    public EasterEggTriggerType TriggerType { get; set; }
    [Key(3)]
    public EasterEggConditionType[] ConditionTypes { get; set; }
    [Key(4)]
    public string[] ConditionValues { get; set; }
    [Key(5)]
    public string Action { get; set; }
    [Key(6)]
    public string[] ActionParams { get; set; }
    [Key(7)]
    public string GroupKey { get; set; }
}
