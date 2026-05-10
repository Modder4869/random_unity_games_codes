using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PVPStatusBonusData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public DateTime ApplyStartDate { get; set; }
    [Key(2)]
    public int HpPercent { get; set; }
    [Key(3)]
    public int AttackPhysicPercent { get; set; }
    [Key(4)]
    public int AttackMagicPercent { get; set; }
    [Key(5)]
    public int DefensePhysicPercent { get; set; }
    [Key(6)]
    public int DefenseMagicPercent { get; set; }
    [Key(7)]
    public int CriticalRatePercent { get; set; }
    [Key(8)]
    public int CriticalMultPercent { get; set; }
    [Key(9)]
    public int CriticalResistPercent { get; set; }
    [Key(10)]
    public int CriticalMultResistPercent { get; set; }
    [Key(11)]
    public int HpRecoveryPercent { get; set; }
    [Key(12)]
    public int SpRecoveryPercent { get; set; }
    [Key(13)]
    public int ShieldPercent { get; set; }
    [Key(14)]
    public int DamagePhysicPercent { get; set; }
    [Key(15)]
    public int DamageMagicPercent { get; set; }
    [Key(16)]
    public int EndDamagePhysicPercent { get; set; }
    [Key(17)]
    public int EndDamageMagicPercent { get; set; }
    [Key(18)]
    public int DamageReducePhysicPercent { get; set; }
    [Key(19)]
    public int DamageReduceMagicPercent { get; set; }
    [Key(20)]
    public int EndDamageReducePhysicPercent { get; set; }
    [Key(21)]
    public int EndDamageReduceMagicPercent { get; set; }
    [Key(22)]
    public int HealingUpPercent { get; set; }
}
