using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqReceiveMixedEventLobbyInteractionReward {
    [Key(0)]
    public int MixedEventUid { get; set; }
    [Key(1)]
    public int LobbyInteractionUid { get; set; }
}
