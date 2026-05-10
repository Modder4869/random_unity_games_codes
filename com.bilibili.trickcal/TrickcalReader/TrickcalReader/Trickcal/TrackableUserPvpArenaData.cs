using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserPvpArenaData {
    [Key(0)]
    public int SeasonId { get; set; }
    [Key(1)]
    public int GroupId { get; set; }
    [Key(2)]
    public int[] DefenseHeroes { get; set; }
    [Key(3)]
    public int DefenseHeroHiddenBits { get; set; }
    [Key(4)]
    public int Ranking { get; set; }
    [Key(5)]
    public int MaxRanking { get; set; }
    [Key(6)]
    public DateTime LastStackRewardTime { get; set; }
    [Key(7)]
    public int StackRewardCount { get; set; }
    [Key(8)]
    public int StackRewardIntervalCount { get; set; }
    [Key(9)]
    public DateTime LastRefreshTime { get; set; }
    [Key(10)]
    public int[] TargetUsers { get; set; }
    [Key(11)]
    public short TicketCount { get; set; }
    [Key(12)]
    public bool IsRankingRewardReceived { get; set; }
    [Key(13)]
    public int[] DefenseHeroesPresets { get; set; }
    [Key(14)]
    public int[] DefenseHeroHiddenBitsPresets { get; set; }
    [Key(15)]
    public string DefenseDeckName { get; set; }
    [Key(16)]
    public string[] DefenseDeckNamePresets { get; set; }
    [Key(17)]
    public int[] DefenseHeroIndexes { get; set; }
}
