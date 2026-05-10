using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackablePocoCompositeKeyDictionary<TKey, TValue> {
    [Key(0)]
    public Dictionary<TKey, TValue> Dictionary { get; set; }
}
