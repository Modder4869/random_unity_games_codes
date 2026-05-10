using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SkillEffectNewData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int UnitUid { get; set; }
    [Key(2)]
    public string SkillAction { get; set; }
    [Key(3)]
    public EffectType EffectType { get; set; }
    [Key(4)]
    public AppliedTargetType AppliedTargetType { get; set; }
    [Key(5)]
    public MoveType MoveType { get; set; }
    [Key(6)]
    public float MoveSpeed { get; set; }
    [Key(7)]
    public int MovePosition { get; set; }
    [Key(8)]
    public PathType PathType { get; set; }
    [Key(9)]
    public TargetConditionType AppliedTargetCondition { get; set; }
    [Key(10)]
    public bool Penetration { get; set; }
    [Key(11)]
    public float ProjectileCollisionSize { get; set; }
    [Key(12)]
    public float ProjectileSpeed { get; set; }
    [Key(13)]
    public ImmortalType ImmortalType { get; set; }
    [Key(14)]
    public bool FollowBone { get; set; }
    [Key(15)]
    public string BoneTarget { get; set; }
    [Key(16)]
    public string BoneSelf { get; set; }
    [Key(17)]
    public string Effect { get; set; }
    [Key(18)]
    public string FireEffectKey { get; set; }
    [Key(19)]
    public string HitEffectKey { get; set; }
    [Key(20)]
    public string HitEffectBorn { get; set; }
    [Key(21)]
    public ExtraBoneType ExtraBoneType { get; set; }
    [Key(22)]
    public string ExtraBone { get; set; }
    [Key(23)]
    public string ExtraEffect { get; set; }
    [Key(24)]
    public string EffectAxis { get; set; }
    [Key(25)]
    public string EffectAngle { get; set; }
    [Key(26)]
    public string HitAxis { get; set; }
    [Key(27)]
    public string HitAngle { get; set; }
    [Key(28)]
    public string ExtraAxis { get; set; }
    [Key(29)]
    public string ExtraAngle { get; set; }
    [Key(30)]
    public float Damage { get; set; }
    [Key(31)]
    public bool FollowExtraBone { get; set; }
    [Key(32)]
    public float ActionDelay { get; set; }
    [Key(33)]
    public string[] TargetEffectBone { get; set; }
    [Key(34)]
    public string[] TargetEffect { get; set; }
    [Key(35)]
    public float AppliedTargetConditionValue { get; set; }
    [Key(36)]
    public TargetSectionType TargetSection { get; set; }
    [Key(37)]
    public TargetJobType TargetJob { get; set; }
    [Key(38)]
    public TargetPersonalityType TargetPersonality { get; set; }
    [Key(39)]
    public TargetTribeType TargetTribe { get; set; }
    [Key(40)]
    public float EffectDelay { get; set; }
    [Key(41)]
    public string[] BeforeEffectBone { get; set; }
    [Key(42)]
    public string[] BeforeEffect { get; set; }
    [Key(43)]
    public bool FixedDirection { get; set; }
    [Key(44)]
    public float InitialPosX { get; set; }
    [Key(45)]
    public float InitialPosY { get; set; }
    [Key(46)]
    public float InitialPosZ { get; set; }
    [Key(47)]
    public bool NewScaleX { get; set; }
    [Key(48)]
    public float ProjectileHitInterval { get; set; }
    [Key(49)]
    public TargetGroupType TargetGroup { get; set; }
    [Key(50)]
    public TargetFallbackType TargetFallbackType { get; set; }
    [Key(51)]
    public string[] PathParams { get; set; }
    [Key(52)]
    public StatusEffectConditionType ConditionType { get; set; }
    [Key(53)]
    public string ConditionTypeValue { get; set; }
    [Key(59)]
    public TargetDamageType TargetDamageType { get; set; }
    [Key(60)]
    public TargetUnitType TargetUnitType { get; set; }
    [Key(61)]
    public bool BeforeEffectFollow { get; set; }
    [Key(62)]
    public bool DelayedFindTarget { get; set; }
    [Key(63)]
    public bool NonTarget { get; set; }
    [Key(64)]
    public TargetConditionType IgnoredTargetCondition { get; set; }
    [Key(65)]
    public float IgnoredTargetConditionValue { get; set; }
    [Key(66)]
    public int HeroCallUI { get; set; }
    [Key(67)]
    public bool FixedInitialPos { get; set; }
    [Key(68)]
    public bool IsCancellable { get; set; }
}
