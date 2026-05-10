using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserChaosArenaData {
    [Key(0)]
    public int DailyPlayCount { get; set; }
    [Key(1)]
    public int SeasonPlayCount { get; set; }
    [Key(2)]
    public int SeasonWinCount { get; set; }
    [Key(3)]
    public int[] ReceivedRewards { get; set; }
    [Key(5)]
    public int Score { get; set; }
    [Key(6)]
    public short SelectedDefenseDeckIndex { get; set; }
    [Key(7)]
    public int[] RecentMatchedUserIds { get; set; }
    [Key(8)]
    public int[] SelectedDefenseCardUids { get; set; }
    [Key(9)]
    public int DailyFirstPlayCount { get; set; }
    [Key(10)]
    public DateTime LastPlayTime { get; set; }
    [Key(11)]
    public int[] SelectedAttackCardUids { get; set; }
    [Key(12)]
    public int Ranking { get; set; }
    [Key(13)]
    public bool IsReceivedDailyReward { get; set; }
    [Key(14)]
    public int HighestScore { get; set; }
    [Key(15)]
    public int GroupId { get; set; }
    [Key(16)]
    public bool IsMatchReady { get; set; }
    [Key(17)]
    public int LastRankingUpdateSeasonPlayCount { get; set; }
}
