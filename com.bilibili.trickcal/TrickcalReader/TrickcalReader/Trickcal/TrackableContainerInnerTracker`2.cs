using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableContainerInnerTracker<TTracker, TValue> {
    [Key(0)]
    public TrackableContainerInnerTrackerChange<TValue> Change { get; set; }
    [Key(1)]
    public TTracker Tracker { get; set; }
}
