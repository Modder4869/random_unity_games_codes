using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrGetCookingTycoonRankings {
    [Key(0)]
    public List<CookingTycoonRankingData> Rankings { get; set; }
}
