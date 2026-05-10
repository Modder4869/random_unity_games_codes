using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackablePocoDictionaryTracker<TKey, TValue> {
    [Key(0)]
    public Dictionary<TKey, Change<TValue>> ChangeMap { get; set; }
}
