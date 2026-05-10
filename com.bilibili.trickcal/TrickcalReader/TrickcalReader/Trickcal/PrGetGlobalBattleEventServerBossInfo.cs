using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrGetGlobalBattleEventServerBossInfo {
    [Key(0)]
    public int Step { get; set; }
    [Key(1)]
    public long StackedHp { get; set; }
    [Key(2)]
    public double CurrentHpPercent { get; set; }
    [Key(3)]
    public long CurrentHp { get; set; }
    [Key(4)]
    public long MyStackedTotalDamage { get; set; }
    [Key(5)]
    public int MyRankingNumber { get; set; }
}
