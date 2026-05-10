using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqGetChaosArenaRankings {
    [Key(0)]
    public int ChaosArenaSeasonId { get; set; }
    [Key(1)]
    public int Page { get; set; }
    [Key(2)]
    public int PageSize { get; set; }
}
