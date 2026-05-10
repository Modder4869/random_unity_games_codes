using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class StageWaveMonsterInfo {
    [Key(0)]
    public int MonsterId { get; set; }
    [Key(1)]
    public int MonsterLevel { get; set; }
    [Key(2)]
    public long StartHp { get; set; }
    [Key(3)]
    public long EndHp { get; set; }
    [Key(4)]
    public long Damage { get; set; }
    [Key(5)]
    public long TakenDamage { get; set; }
    [Key(6)]
    public long Heal { get; set; }
    [Key(7)]
    public long TakenHeal { get; set; }
}
