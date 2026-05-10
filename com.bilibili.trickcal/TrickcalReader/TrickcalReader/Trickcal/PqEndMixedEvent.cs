using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqEndMixedEvent {
    [Key(0)]
    public int MixedEventUid { get; set; }
}
