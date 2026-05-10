using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqMatchChaosArena {
    [Key(0)]
    public int ChaosArenaSeasonId { get; set; }
}
