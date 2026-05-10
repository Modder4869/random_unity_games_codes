using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TableBasePvpBotStatData {
    [Key(0)]
    public float Hp { get; set; }
    [Key(1)]
    public float AttackPhysic { get; set; }
    [Key(2)]
    public float AttackMagic { get; set; }
    [Key(3)]
    public float DefensePhysic { get; set; }
    [Key(4)]
    public float DefenseMagic { get; set; }
    [Key(5)]
    public float CriticalRate { get; set; }
    [Key(6)]
    public float CriticalMult { get; set; }
    [Key(7)]
    public float CriticalResist { get; set; }
    [Key(8)]
    public float CriticalMultResist { get; set; }
    [Key(9)]
    public float AttackSpeed { get; set; }
}
