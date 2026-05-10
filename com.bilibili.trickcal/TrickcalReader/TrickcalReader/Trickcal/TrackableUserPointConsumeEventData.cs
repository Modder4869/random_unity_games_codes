using MessagePack;

namespace Trickcal.Shared;
using System.Collections;
[MessagePackObject]
public class TrackableUserPointConsumeEventData {
    [Key(0)]
    public BitArray OpenedSteps { get; set; }
    [Key(1)]
    public bool ReceivedRewardCompleteStepGroup { get; set; }
}
