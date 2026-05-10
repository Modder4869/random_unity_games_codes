using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class StageWaveHeroInfo {
    [Key(0)]
    public int HeroId { get; set; }
    [Key(1)]
    public short Grow { get; set; }
    [Key(2)]
    public short DeathCount { get; set; }
    [Key(3)]
    public long StartHp { get; set; }
    [Key(4)]
    public long EndHp { get; set; }
    [Key(5)]
    public long Damage { get; set; }
    [Key(6)]
    public long TakenDamage { get; set; }
    [Key(7)]
    public long Heal { get; set; }
    [Key(8)]
    public long TakenHeal { get; set; }
    [Key(9)]
    public int SPSkillUseCount { get; set; }
    [Key(10)]
    public int UltimateSkillUseCount { get; set; }
    [Key(11)]
    public HeroPlayType PlayType { get; set; }
}
