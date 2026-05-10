using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableChange<TValue> {
    [Key(0)]
    public TValue NewValue { get; set; }
    [Key(1)]
    public TValue OldValue { get; set; }
}
