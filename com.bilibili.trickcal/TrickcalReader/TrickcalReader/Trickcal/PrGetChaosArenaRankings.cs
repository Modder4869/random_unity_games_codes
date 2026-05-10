using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrGetChaosArenaRankings {
    [Key(0)]
    public List<ChaosArenaRankingData> Rankings { get; set; }
}
