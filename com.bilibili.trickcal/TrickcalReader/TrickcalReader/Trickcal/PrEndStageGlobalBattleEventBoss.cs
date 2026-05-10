using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrEndStageGlobalBattleEventBoss {
    [Key(0)]
    public bool IsClear { get; set; }
    [Key(1)]
    public bool IsFirstClear { get; set; }
    [Key(2)]
    public StageClearState StageClearState { get; set; }
    [Key(3)]
    public List<Goods> FirstClearRewards { get; set; }
    [Key(4)]
    public List<Goods> ClearRewards { get; set; }
    [Key(5)]
    public List<Goods> PlayRewards { get; set; }
    [Key(6)]
    public long TotalDamage { get; set; }
    [Key(7)]
    public long TotalHp { get; set; }
    [Key(8)]
    public GlobalBattleEventBossWaveDamageInfo[] WaveDamageInfos { get; set; }
}
