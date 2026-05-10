using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqReceiveAllEventAttendanceDailyReward {
    [Key(0)]
    public int EventId { get; set; }
}
