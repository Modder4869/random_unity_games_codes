namespace Trickcal.Shared;

public enum SkillType : int {
    None = 0,
    BasicAttack = 1,
    PowerAttack = 2,
    Active = 3,
    Ultimate = 4,
    CoolTime = 5,
    HpCondition = 6,
    ConditionSkill = 7,
    SPSkill = 8,
    ControlSkill = 9,
    BornTalent = 10,
    SignatureAttack = 11,
    BasicAttackOverwrite = 12,
    PowerAttackOverwrite = 13,
    SPSkillOverwrite = 14,
    UltimateOverwrite = 15,
    SignatureAttackOverwrite = 16,
    AutoTrigger = 17,
    HpLine = 18,
    Augment = 19,
    Passive = 20,
    Gimmick = 21,
    UserSkill = 22,
    SignaturePassive = 23
}
