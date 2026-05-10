using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqSetEventLobbyViewed {
    [Key(0)]
    public int EventLobbyId { get; set; }
}
