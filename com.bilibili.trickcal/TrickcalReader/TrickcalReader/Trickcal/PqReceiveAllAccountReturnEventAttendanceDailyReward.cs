using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqReceiveAllAccountReturnEventAttendanceDailyReward {
    [Key(0)]
    public int EventId { get; set; }
}
