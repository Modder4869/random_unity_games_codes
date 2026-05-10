namespace Trickcal.Shared;

public enum TowerBattleMatchFailType : int {
    None = 0,
    Unknown = 1,
    MatchTimeOver = 2,
    SeasonEnded = 3,
    ScheduleDataNotFound = 4,
    ContentsMaintenance = 5
}
