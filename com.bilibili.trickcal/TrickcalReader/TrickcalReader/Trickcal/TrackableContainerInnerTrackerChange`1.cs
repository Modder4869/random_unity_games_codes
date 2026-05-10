using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableContainerInnerTrackerChange<TValue> {
    [Key(0)]
    public TrackableContainerInnerTrackerState State { get; set; }
    [Key(1)]
    public TValue OldValue { get; set; }
    [Key(2)]
    public TValue NewValue { get; set; }
}
