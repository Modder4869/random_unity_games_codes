using MessagePack;
using System.Collections;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserGachaponEventData {
    [Key(0)]
    public int DrawCount { get; set; }
    [Key(1)]
    public BitArray ReceivedStepReward { get; set; }
}
