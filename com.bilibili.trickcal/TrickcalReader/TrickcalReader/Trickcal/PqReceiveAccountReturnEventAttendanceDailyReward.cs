using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqReceiveAccountReturnEventAttendanceDailyReward {
    [Key(0)]
    public int EventId { get; set; }
    [Key(1)]
    public short DayIndex { get; set; }
}
