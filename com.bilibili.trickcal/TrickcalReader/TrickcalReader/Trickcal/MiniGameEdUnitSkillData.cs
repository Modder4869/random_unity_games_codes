using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class MiniGameEdUnitSkillData : TableItem<TableData> {
    [Key(0)]
    public int MiniGameUid { get; set; }
    [Key(1)]
    public int UnitInfoUid { get; set; }
    [Key(2)]
    public int UnitGradeUid { get; set; }
    [Key(3)]
    public int SkillUid { get; set; }
    [Key(4)]
    public TowerSkillType SkillType { get; set; }
    [Key(5)]
    public string SpineBattle { get; set; }
    [Key(6)]
    public TowerSkillConditionType ConditionType { get; set; }
    [Key(7)]
    public float ConditionValue { get; set; }
    [Key(8)]
    public TowerSkillEffectType SkillEffectType { get; set; }
    [Key(9)]
    public float SkillEffectDuration { get; set; }
    [Key(10)]
    public float SkillEffectValue { get; set; }
    [Key(11)]
    public string AttackVfxName { get; set; }
    [Key(12)]
    public float AttackVfxScale { get; set; }
    [Key(13)]
    public float AttackVfxOffsetX { get; set; }
    [Key(14)]
    public float AttackVfxOffsetY { get; set; }
    [Key(15)]
    public string HitVfxName { get; set; }
    [Key(16)]
    public float HitVfxScale { get; set; }
    [Key(17)]
    public float HitVfxOffsetX { get; set; }
    [Key(18)]
    public float HitVfxOffsetY { get; set; }
    [Key(19)]
    public float EffectTiming { get; set; }
    [Key(20)]
    public float HitEffectTiming { get; set; }
    [Key(21)]
    public string ProjectileEffect { get; set; }
    [Key(22)]
    public float ProjectileEffectScale { get; set; }
    [Key(23)]
    public float ProjectileEffectPosX { get; set; }
    [Key(24)]
    public float ProjectileEffectPosY { get; set; }
    [Key(25)]
    public float ProjectileSpeed { get; set; }
    [Key(26)]
    public float ParamStatSize { get; set; }
    [Key(27)]
    public float ProjectileTime { get; set; }
    [Key(28)]
    public float ProjectileSize { get; set; }
    [Key(29)]
    public string ParamEffect { get; set; }
}
