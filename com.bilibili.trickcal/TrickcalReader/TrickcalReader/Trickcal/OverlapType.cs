namespace Trickcal.Shared;

public enum OverlapType : int {
    Stack = 0,
    StackRenew = 1,
    Remain = 2,
    Replaceable = 3,
    TimeExtension = 4,
    TimeExtensionInfinity = 5,
    TimeRefresh = 6,
    StackOverTrigger = 7
}
