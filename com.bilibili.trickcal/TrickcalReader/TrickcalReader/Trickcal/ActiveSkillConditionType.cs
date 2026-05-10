namespace Trickcal.Shared;

public enum ActiveSkillConditionType : int {
    None = 0,
    AllEnemy = 1,
    AllEnemySingleHighestHpPercent = 2,
    NormalEnemySingleHighestHpPercent = 3,
    AllEnemyRangeHighestHpPercent = 4
}
