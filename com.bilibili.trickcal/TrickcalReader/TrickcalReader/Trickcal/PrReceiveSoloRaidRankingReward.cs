using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrReceiveSoloRaidRankingReward {
    [Key(0)]
    public int Ranking { get; set; }
}
