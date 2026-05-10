using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class GlobalBattleEventServerBossData : TableItem<TableData> {
    [Key(0)]
    public int GlobalBattleEventUid { get; set; }
    [Key(1)]
    public int BossStep { get; set; }
    [Key(2)]
    public int BossMonsterUid { get; set; }
    [Key(3)]
    public int BossLevel { get; set; }
    [Key(4)]
    public int[] Rewards { get; set; }
    [Key(5)]
    public int ServerBossMonsterStatusBonusGroup { get; set; }
}
