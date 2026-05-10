namespace Trickcal.Shared;

public enum SignatureEffectType : int {
    None = 0,
    SignatureAttackAdd = 1,
    PassiveSkillAdd = 2,
    BasicAttackOverwrite = 3,
    PowerAttackOverwrite = 4,
    SignatureAttackOverwrite = 5,
    SPSkillOverwrite = 6,
    UltimateOverwrite = 7,
    PassiveAttackPhysicUpPercent = 8,
    PassiveAttackMagicUpPercent = 9,
    PassiveCriticalRateUpPercent = 10,
    PassiveCriticalMultUpPercent = 11,
    PassiveDefenseUpPercent = 12,
    PassiveDefensePhysicUpPercent = 13,
    PassiveDefenseMagicUpPercent = 14,
    PassiveCriticalMultResistUpPercent = 15,
    PassiveMaxHpUpPercent = 16,
    PassiveCriticalResistUpPercent = 17,
    PassiveAttackSpeedUpPercent = 18,
    PassiveNormalAttackDamageUpPercent = 19,
    PassiveRecoverySpUp = 20,
    PassiveRecoverySpUpPercent = 21,
    PassiveUltimateCoolTimeReduce = 22,
    StatusEffectGlobal = 23
}
