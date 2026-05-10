using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestSetChaosArenaScore {
    [Key(0)]
    public int SeasonId { get; set; }
    [Key(1)]
    public int Score { get; set; }
}
