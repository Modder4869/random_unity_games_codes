using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SkillLevelNewData : TableItem<TableData> {
    [Key(0)]
    public int UnitUid { get; set; }
    [Key(1)]
    public int SkillUid { get; set; }
    [Key(2)]
    public int SkillEffectUid { get; set; }
    [Key(3)]
    public int SkillLevel { get; set; }
    [Key(4)]
    public int GrowCondition { get; set; }
    [Key(5)]
    public int EquipArtiCondition { get; set; }
    [Key(6)]
    public int MultiCount { get; set; }
    [Key(7)]
    public HitBoxType HitBoxType { get; set; }
    [Key(8)]
    public HitBoxoffset HitBoxoffset { get; set; }
    [Key(9)]
    public float HitBoxWidth { get; set; }
    [Key(10)]
    public float HitBoxLength { get; set; }
    [Key(11)]
    public int DamageMin { get; set; }
    [Key(12)]
    public int DamageMax { get; set; }
    [Key(13)]
    public int DamageInterval { get; set; }
    [Key(14)]
    public int FixDamageValue { get; set; }
    [Key(15)]
    public float DOTInterval { get; set; }
    [Key(16)]
    public float HealMin { get; set; }
    [Key(17)]
    public float HealMax { get; set; }
    [Key(18)]
    public int HealInterval { get; set; }
    [Key(19)]
    public float FixHealValue { get; set; }
    [Key(20)]
    public float DOHInterval { get; set; }
    [Key(21)]
    public float DurationMin { get; set; }
    [Key(22)]
    public float DurationMax { get; set; }
    [Key(23)]
    public float DurationInterval { get; set; }
    [Key(24)]
    public float SPMagnification { get; set; }
    [Key(25)]
    public bool Stiffen { get; set; }
    [Key(26)]
    public float KnockBack { get; set; }
    [Key(28)]
    public float[] ParamData { get; set; }
    [Key(29)]
    public float Push { get; set; }
    [Key(30)]
    public float HitBoxOffsetX { get; set; }
    [Key(31)]
    public Target SeTargetType { get; set; }
    [Key(32)]
    public TargetRangeType SeRangeType { get; set; }
    [Key(33)]
    public float SeBoxWidth { get; set; }
    [Key(34)]
    public float SeBoxLength { get; set; }
    [Key(35)]
    public SeApplyType SeApplyType { get; set; }
    [Key(36)]
    public int SeApplyRandomCnt { get; set; }
    [Key(37)]
    public int SeApplyUId { get; set; }
    [Key(38)]
    public float[] SeParam { get; set; }
    [Key(39)]
    public bool PVPBalance { get; set; }
    [Key(40)]
    public string[] ParamString { get; set; }
    [Key(41)]
    public bool IgnoreBlind { get; set; }
    [Key(42)]
    public string[] ParamDataNew { get; set; }
}
