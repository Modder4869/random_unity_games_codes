using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqReceiveCookingTycoonRankingReward {
    [Key(0)]
    public int CookingTycoonSeason { get; set; }
}
