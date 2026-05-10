using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestSetArcadeSeasonMiniGameIsReceivedRankingReward {
    [Key(0)]
    public int Season { get; set; }
    [Key(1)]
    public bool IsReceivedRankingReward { get; set; }
}
