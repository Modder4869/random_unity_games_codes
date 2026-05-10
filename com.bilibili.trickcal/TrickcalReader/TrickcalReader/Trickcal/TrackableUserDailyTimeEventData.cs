using MessagePack;
using System.Collections;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserDailyTimeEventData {
    [Key(0)]
    public BitArray ReceivedReward { get; set; }
}
