using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrGetSoloEndRankings {
    [Key(0)]
    public List<SoloEndRankingData> SoloEndRankings { get; set; }
}
