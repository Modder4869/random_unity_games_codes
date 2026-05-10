using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class MiniGameEdActiveSkillData : TableItem<TableData> {
    [Key(0)]
    public int MiniGameUid { get; set; }
    [Key(1)]
    public int HeroUid { get; set; }
    [Key(2)]
    public string ActiveSkillName { get; set; }
    [Key(3)]
    public string ActiveSkillDesc { get; set; }
    [Key(4)]
    public string ActiveSkillIcon { get; set; }
    [Key(5)]
    public string Voice { get; set; }
    [Key(6)]
    public int DefaultCharge { get; set; }
    [Key(7)]
    public int MaxCharge { get; set; }
    [Key(8)]
    public int ChargeTime { get; set; }
    [Key(9)]
    public ActiveSkillConditionType ConditionType { get; set; }
    [Key(10)]
    public float ConditionValue { get; set; }
    [Key(11)]
    public ActiveSkillEffectType EffectType { get; set; }
    [Key(12)]
    public float SkillEffectDuration { get; set; }
    [Key(13)]
    public float SkillEffectValue { get; set; }
    [Key(14)]
    public string AttackVfxName { get; set; }
    [Key(15)]
    public float AttackVfxScale { get; set; }
    [Key(16)]
    public float AttackVfxOffsetX { get; set; }
    [Key(17)]
    public float AttackVfxOffsetY { get; set; }
    [Key(18)]
    public string HitVfxName { get; set; }
    [Key(19)]
    public float HitVfxScale { get; set; }
    [Key(20)]
    public float HitVfxOffsetX { get; set; }
    [Key(21)]
    public float HitVfxOffsetY { get; set; }
    [Key(22)]
    public string EffectName { get; set; }
    [Key(23)]
    public float EffectStatSize { get; set; }
    [Key(24)]
    public float EffectTiming { get; set; }
    [Key(25)]
    public float EffectSpeed { get; set; }
    [Key(26)]
    public float HitEffectTiming { get; set; }
    [Key(27)]
    public EffectPosition ParamEffectPosition { get; set; }
    [Key(28)]
    public string OutputSound { get; set; }
    [Key(29)]
    public string HitSound { get; set; }
    [Key(30)]
    public string SelectBeforeAni { get; set; }
    [Key(31)]
    public string SelectAfterAni { get; set; }
    [Key(32)]
    public string DurationAni { get; set; }
}
