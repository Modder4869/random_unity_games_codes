using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserTowerBattleData {
    [Key(0)]
    public int Score { get; set; }
    [Key(1)]
    public int DailyPlayCount { get; set; }
    [Key(2)]
    public int WinCount { get; set; }
    [Key(3)]
    public int LoseCount { get; set; }
    [Key(4)]
    public int StreakWinCount { get; set; }
    [Key(5)]
    public int PenaltyCount { get; set; }
    [Key(6)]
    public int HighestStreakWinCount { get; set; }
    [Key(7)]
    public int MatchHighestObjectCount { get; set; }
    [Key(8)]
    public DateTime LastPlayTime { get; set; }
    [Key(9)]
    public int ScoreRanking { get; set; }
    [Key(10)]
    public int StreakWinRanking { get; set; }
    [Key(11)]
    public string PlayingMatchId { get; set; }
    [Key(12)]
    public bool IsAbortedMatch { get; set; }
    [Key(13)]
    public bool IsDisconnectedMatch { get; set; }
    [Key(14)]
    public int GroupId { get; set; }
    [Key(15)]
    public int DailyPenaltyCount { get; set; }
    [Key(16)]
    public TowerBattlePenaltyType PenaltyType { get; set; }
    [Key(17)]
    public int HighestScore { get; set; }
    [Key(18)]
    public DateTime StreakWinRankingUpdatedTime { get; set; }
}
