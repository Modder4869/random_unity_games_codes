using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TableBaseStatIncreaseData {
    [Key(0)]
    public float HpIncrease { get; set; }
    [Key(1)]
    public float RecoverySpIncrease { get; set; }
    [Key(2)]
    public float HealingIncrease { get; set; }
    [Key(3)]
    public float AttackPhysicIncrease { get; set; }
    [Key(4)]
    public float AttackMagicIncrease { get; set; }
    [Key(5)]
    public float DefensePhysicIncrease { get; set; }
    [Key(6)]
    public float DefenseMagicIncrease { get; set; }
    [Key(7)]
    public float CriticalRateIncrease { get; set; }
    [Key(8)]
    public float CriticalMultIncrease { get; set; }
    [Key(9)]
    public float CriticalResistIncrease { get; set; }
    [Key(10)]
    public float CriticalMultResistIncrease { get; set; }
    [Key(11)]
    public float AttackRangeIncrease { get; set; }
    [Key(12)]
    public float AttackSpeedIncrease { get; set; }
}
