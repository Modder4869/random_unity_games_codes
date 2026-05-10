using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class GlobalBattleEventData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int GlobalBattleEventWorldGroupUid { get; set; }
    [Key(2)]
    public int GlobalBattleEventBossUid { get; set; }
    [Key(3)]
    public int BonusHeroGroupUid { get; set; }
    [Key(4)]
    public int[] EventCurrencyItemUids { get; set; }
    [Key(5)]
    public int BossEnterCurrencyUid { get; set; }
    [Key(6)]
    public int BossEnterCurrencyDailyRefillCount { get; set; }
    [Key(7)]
    public int ServerBossDamageRate { get; set; }
    [Key(8)]
    public string SkipBackground { get; set; }
}
