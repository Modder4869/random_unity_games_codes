namespace Trickcal.Shared;

public enum RecallType : int {
    None = 0,
    Level = 1,
    Equip = 2,
    EquipEnchant = 4,
    Skill = 8,
    Grade = 16,
    Board = 32,
    Aside = 64,
    All = 123
}
