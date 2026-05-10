using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackablePocoTracker<T> {
    [Key(0)]
    public IEnumerable<(int, ITrackableChange)> ChangeListList { get; set; }
}
