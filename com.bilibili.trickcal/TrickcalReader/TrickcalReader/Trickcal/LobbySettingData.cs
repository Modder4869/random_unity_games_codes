using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class LobbySettingData {
    [Key(0)]
    public UserLobbyKey Key { get; set; }
    [Key(1)]
    public bool IsDelete { get; set; }
    [Key(2)]
    public int LobbyId { get; set; }
    [Key(3)]
    public int[] HeroIds { get; set; }
    [Key(4)]
    public int ButtonId { get; set; }
}
