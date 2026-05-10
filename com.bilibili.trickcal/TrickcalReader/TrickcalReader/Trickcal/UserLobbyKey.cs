using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public struct UserLobbyKey {
    [Key(0)]
    public LobbyDataType Type { get; set; }
    [Key(1)]
    public int Index { get; set; }
}
