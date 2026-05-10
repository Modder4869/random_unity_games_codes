namespace Trickcal.Shared;

public enum EventConditionType : int {
    None = 0,
    Back = 1,
    PayCount = 2,
    NewAccount = 3,
    NewAccountOrBack = 4,
    Current = 5,
    AccountReturn = 6,
    NewAccountOrMinimumStageNotClear = 7,
    MinimumStageClear = 8,
    EventTrigger = 9
}
