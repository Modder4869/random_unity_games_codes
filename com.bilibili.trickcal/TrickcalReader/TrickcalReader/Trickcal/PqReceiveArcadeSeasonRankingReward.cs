using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqReceiveArcadeSeasonRankingReward {
    [Key(0)]
    public int ArcadeSeasonUid { get; set; }
}
