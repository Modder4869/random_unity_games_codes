using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqEnterWWELobby {
    [Key(0)]
    public int SeasonId { get; set; }
}
