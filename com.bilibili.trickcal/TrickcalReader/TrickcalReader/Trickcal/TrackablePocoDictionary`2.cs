using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackablePocoDictionary<TKey, TValue> {
    [Key(0)]
    public Dictionary<TKey, TValue> Dictionary { get; set; }
}
