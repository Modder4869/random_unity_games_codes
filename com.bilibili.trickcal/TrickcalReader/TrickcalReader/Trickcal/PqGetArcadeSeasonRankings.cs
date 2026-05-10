using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqGetArcadeSeasonRankings {
    [Key(0)]
    public int ArcadeSeasonUid { get; set; }
    [Key(1)]
    public int Page { get; set; }
    [Key(2)]
    public int PageSize { get; set; }
    [Key(3)]
    public bool RefreshMyRanking { get; set; }
}
