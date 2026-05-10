namespace Trickcal.Shared;

public enum TowerBattleRoomCloseReason : int {
    None = 0,
    Unknown = 1,
    ClosedByGmTool = 2,
    SeasonEnded = 3,
    ScheduleDataNotFound = 4,
    RoomError = 5,
    ContentsMaintenance = 6,
    DayChanged = 7
}
