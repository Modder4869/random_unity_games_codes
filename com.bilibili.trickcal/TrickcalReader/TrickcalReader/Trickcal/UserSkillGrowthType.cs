namespace Trickcal.Shared;

public enum UserSkillGrowthType : int {
    None = 0,
    UseSkillWithDelay = 1,
    UseUserSkillNoCost = 2,
    GainGauge = 3,
    SkillDamagePercent = 4,
    ImmediateReloadRate = 5,
    ReloadTimePercent = 6,
    MaxGaugeCount = 7,
    SkillNoCostRate = 8,
    ShowSpecialBullet = 9
}
