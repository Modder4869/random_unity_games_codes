using MessagePack;
using System.Collections;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserPointEventData {
    [Key(0)]
    public BitArray ReceivedItemSteps { get; set; }
    [Key(1)]
    public BitArray ReceivedItemGroups { get; set; }
}
