using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class GlobalBattleEventBossWaveDamageInfo {
    [Key(0)]
    public long Damage { get; set; }
    [Key(1)]
    public long TotalHp { get; set; }
    [Key(2)]
    public int PlayTimeSeconds { get; set; }
    [Key(3)]
    public int MaxPlayTimeSeconds { get; set; }
    [Key(4)]
    public long TimeBonus { get; set; }
}
