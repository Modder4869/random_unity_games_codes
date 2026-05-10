using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqReceiveMixedEventLobbyReward {
    [Key(0)]
    public int MixedEventUid { get; set; }
    [Key(1)]
    public int LobbyRewardUid { get; set; }
}
