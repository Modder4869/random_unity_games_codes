using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqSetLobbySettings {
    [Key(0)]
    public bool IsRandom { get; set; }
    [Key(1)]
    public LobbySettingData[] Settings { get; set; }
}
