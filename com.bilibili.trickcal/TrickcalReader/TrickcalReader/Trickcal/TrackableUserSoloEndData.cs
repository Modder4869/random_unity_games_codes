using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserSoloEndData {
    [Key(0)]
    public short EnterNormalWorldCount { get; set; }
    [Key(1)]
    public int LastClearedBossStageId { get; set; }
    [Key(2)]
    public long StageHighestScore { get; set; }
    [Key(3)]
    public long HighestScore { get; set; }
    [Key(4)]
    public short HighestLastStagePlayTimeSeconds { get; set; }
    [Key(5)]
    public DateTime HighestLastStageStartTime { get; set; }
    [Key(6)]
    public int Ranking { get; set; }
    [Key(7)]
    public bool IsRewardReceived { get; set; }
    [Key(8)]
    public int MaximumCoin { get; set; }
    [Key(9)]
    public int HighestPlayTotalPower { get; set; }
    [Key(10)]
    public int HighestLastStageDeathCount { get; set; }
    [Key(11)]
    public int RankingPercent { get; set; }
    [Key(12)]
    public int GroupId { get; set; }
}
