using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrGetArcadeSeasonRankings {
    [Key(0)]
    public List<ArcadeSeasonRankingData> Rankings { get; set; }
}
