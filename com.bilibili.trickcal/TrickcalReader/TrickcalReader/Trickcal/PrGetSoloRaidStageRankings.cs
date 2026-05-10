using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrGetSoloRaidStageRankings {
    [Key(0)]
    public List<SoloRaidStageRankingCache> TopRankings { get; set; }
}
