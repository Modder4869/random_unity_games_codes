using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserSoloRaidData {
    [Key(0)]
    public int LastClearedStageId { get; set; }
    [Key(1)]
    public int LastFirstClearStageId { get; set; }
    [Key(2)]
    public int[] UsedHeroes { get; set; }
    [Key(3)]
    public long TotalDamage { get; set; }
    [Key(4)]
    public short LastStagePlayTimeSeconds { get; set; }
    [Key(5)]
    public DateTime LastStageStartTime { get; set; }
    [Key(6)]
    public int RankingNumber { get; set; }
    [Key(7)]
    public long LastStageTotalDamage { get; set; }
    [Key(8)]
    public bool IsRewardReceived { get; set; }
    [Key(9)]
    public short ResetCount { get; set; }
    [Key(10)]
    public int[] RentUserIds { get; set; }
    [Key(11)]
    public int RentCount { get; set; }
    [Key(12)]
    public short DataIndex { get; set; }
    [Key(13)]
    public short HighestDataIndex { get; set; }
    [Key(14)]
    public long HighestTotalDamage { get; set; }
    [Key(15)]
    public short HighestLastStagePlayTimeSeconds { get; set; }
    [Key(16)]
    public DateTime HighestLastStageStartTime { get; set; }
    [Key(17)]
    public long TimeBonus { get; set; }
    [Key(18)]
    public long HighestTimeBonus { get; set; }
    [Key(19)]
    public long Score { get; set; }
    [Key(20)]
    public long HighestScore { get; set; }
    [Key(21)]
    public int GroupId { get; set; }
    [Key(22)]
    public int RankingPercent { get; set; }
}
