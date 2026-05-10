using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrGetSoloRaidRankings {
    [Key(0)]
    public List<SoloRaidRankingData> TopRankings { get; set; }
}
