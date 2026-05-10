using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ChaosArenaRuleInfoData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public ChaosArenaRuleType Type { get; set; }
    [Key(2)]
    public int RuleInfoGroup { get; set; }
    [Key(3)]
    public string Icon { get; set; }
    [Key(4)]
    public string Desc { get; set; }
    [Key(5)]
    public bool IsMainRule { get; set; }
    [Key(6)]
    public string[] DescParam { get; set; }
}
