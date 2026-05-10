using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class GlobalBattleEventBossBuff : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int WorldRuleUid { get; set; }
    [Key(2)]
    public ContentsUnlockType ConditionType { get; set; }
    [Key(3)]
    public int ConditionValue { get; set; }
}
