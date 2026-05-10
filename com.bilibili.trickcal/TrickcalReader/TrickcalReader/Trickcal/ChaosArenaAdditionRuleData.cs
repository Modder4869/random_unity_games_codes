using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ChaosArenaAdditionRuleData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int AdditionRuleGroupUid { get; set; }
    [Key(2)]
    public int RuleInfoGroupUid { get; set; }
    [Key(3)]
    public ChaosArenaAdditionType AdditionType { get; set; }
}
