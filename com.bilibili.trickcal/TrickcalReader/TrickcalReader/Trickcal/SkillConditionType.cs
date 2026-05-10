namespace Trickcal.Shared;

public enum SkillConditionType : int {
    None = 0,
    Probability = 1,
    Stack = 2,
    HitStack = 3,
    StatusEffectSelf = 4,
    StatusEffectAlly = 5,
    StatusEffectAllyEx = 6,
    StatusEffectEnemy = 7,
    CoolTime = 8,
    HpCondition = 9,
    Sp = 10
}
