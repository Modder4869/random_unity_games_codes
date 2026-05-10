using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqEnterCookingTycoonLobby {
    [Key(0)]
    public int CookingTycoonSeason { get; set; }
}
