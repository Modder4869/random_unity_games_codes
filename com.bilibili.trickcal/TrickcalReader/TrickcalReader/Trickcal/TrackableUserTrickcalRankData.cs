using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserTrickcalRankData {
    [Key(0)]
    public int SeasonId { get; set; }
    [Key(1)]
    public int[] DefenseHeroes { get; set; }
    [Key(2)]
    public TierGrade Tier { get; set; }
    [Key(3)]
    public TierGrade MaxTier { get; set; }
    [Key(4)]
    public TierGrade LastReceivedRewardTier { get; set; }
    [Key(5)]
    public int Score { get; set; }
    [Key(6)]
    public int TicketCount { get; set; }
    [Key(7)]
    public int TicketRefillCount { get; set; }
    [Key(8)]
    public int MatchCount { get; set; }
    [Key(9)]
    public int LastSeasonRanking { get; set; }
    [Key(10)]
    public DateTime LastMatchTime { get; set; }
    [Key(11)]
    public bool IsReceivedSeasonReward { get; set; }
    [Key(12)]
    public int LastSeasonId { get; set; }
}
