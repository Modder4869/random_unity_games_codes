using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserCookingTycoonData {
    [Key(0)]
    public int Ranking { get; set; }
    [Key(1)]
    public bool ReceivedRankingReward { get; set; }
    [Key(2)]
    public int HighestScore { get; set; }
    [Key(3)]
    public int HighestScorePlayDuration { get; set; }
    [Key(4)]
    public DateTime HighestScoreAchievedTime { get; set; }
    [Key(5)]
    public int[] ClearedStage { get; set; }
    [Key(6)]
    public int GroupId { get; set; }
}
