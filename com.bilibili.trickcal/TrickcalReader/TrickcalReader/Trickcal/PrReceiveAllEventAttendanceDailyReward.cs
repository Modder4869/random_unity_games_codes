using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrReceiveAllEventAttendanceDailyReward {
    [Key(0)]
    public List<int> ReceivedDayIndexList { get; set; }
}
