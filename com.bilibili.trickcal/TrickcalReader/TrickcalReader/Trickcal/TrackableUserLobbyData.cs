using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserLobbyData {
    [Key(0)]
    public int LobbyId { get; set; }
    [Key(1)]
    public int[] HeroIds { get; set; }
    [Key(2)]
    public int ButtonId { get; set; }
}
