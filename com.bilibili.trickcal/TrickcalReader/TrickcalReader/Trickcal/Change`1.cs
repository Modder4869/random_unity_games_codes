using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public struct Change<T> {
    [Key(0)]
    public TrackablePocoDictionaryOperation Operation { get; set; }
    [Key(1)]
    public T NewValue { get; set; }
    [Key(2)]
    public TrackablePocoTracker<T> PocoTracker { get; set; }
}
