namespace Trickcal.Shared;

public enum UserSkillTriggerType : int {
    None = 0,
    Passive = 1,
    Reload = 2,
    UseUserSkill = 3,
    KillWithUserSkill = 4,
    OnTriggerSkill = 5,
    OnGaugeChange = 6,
    OnGrowthChange = 7
}
