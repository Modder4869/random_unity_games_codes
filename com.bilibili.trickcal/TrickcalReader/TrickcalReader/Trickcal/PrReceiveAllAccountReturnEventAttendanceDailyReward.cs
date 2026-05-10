using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrReceiveAllAccountReturnEventAttendanceDailyReward {
    [Key(0)]
    public List<int> ReceivedDayIndexList { get; set; }
}
