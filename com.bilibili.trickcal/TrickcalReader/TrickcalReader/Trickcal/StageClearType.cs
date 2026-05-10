namespace Trickcal.Shared;

public enum StageClearType : short {
    None = 0,
    NoClear = 0,
    Clear = 1,
    FirstClear = 2,
    Skip = 4,
    Star1 = 16,
    Star2 = 32,
    Star3 = 64,
    ClearEventStage = 128,
    AllClearByFirst = 115
}
