using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestSetCookingTycoonIsReceivedRankingReward {
    [Key(0)]
    public int Season { get; set; }
    [Key(1)]
    public bool IsReceivedRankingReward { get; set; }
}
