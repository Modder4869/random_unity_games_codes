using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TableBaseStatData {
    [Key(0)]
    public double Hp { get; set; }
    [Key(1)]
    public double Sp { get; set; }
    [Key(2)]
    public double RecoverySp { get; set; }
    [Key(3)]
    public double Healing { get; set; }
    [Key(4)]
    public double AttackPhysic { get; set; }
    [Key(5)]
    public double AttackMagic { get; set; }
    [Key(6)]
    public double DefensePhysic { get; set; }
    [Key(7)]
    public double DefenseMagic { get; set; }
    [Key(8)]
    public double CriticalRate { get; set; }
    [Key(9)]
    public double CriticalMult { get; set; }
    [Key(10)]
    public double CriticalResist { get; set; }
    [Key(11)]
    public double CriticalMultResist { get; set; }
    [Key(12)]
    public double PushResist { get; set; }
    [Key(13)]
    public double MoveSpeed { get; set; }
    [Key(14)]
    public double AttackRange { get; set; }
    [Key(15)]
    public double AttackSpeed { get; set; }
}
