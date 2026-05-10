using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqStartChaosArenaMatch {
    [Key(0)]
    public int ChaosArenaSeasonId { get; set; }
}
