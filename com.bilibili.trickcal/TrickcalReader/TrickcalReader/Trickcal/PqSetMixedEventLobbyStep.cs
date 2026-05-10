using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqSetMixedEventLobbyStep {
    [Key(0)]
    public int MixedEventUid { get; set; }
    [Key(1)]
    public int Step { get; set; }
}
