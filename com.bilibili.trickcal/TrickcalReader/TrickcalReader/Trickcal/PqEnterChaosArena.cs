using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqEnterChaosArena {
    [Key(0)]
    public int ChaosArenaSeasonId { get; set; }
}
