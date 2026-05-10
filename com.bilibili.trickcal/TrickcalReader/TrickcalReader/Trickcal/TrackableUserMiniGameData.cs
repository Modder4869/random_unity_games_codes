using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserMiniGameData {
    [Key(0)]
    public int Score { get; set; }
    [Key(1)]
    public EventType EventType { get; set; }
    [Key(2)]
    public int EventId { get; set; }
    [Key(3)]
    public DateTime LastPlayTime { get; set; }
    [Key(4)]
    public JsonString? SaveData { get; set; }
    [Key(5)]
    public int GroupId { get; set; }
    [Key(6)]
    public int ArcadeSeasonUid { get; set; }
    [Key(7)]
    public int ArcadeSeasonRanking { get; set; }
    [Key(8)]
    public bool IsArcadeSeasonRankingRewardReceived { get; set; }
    [Key(9)]
    public int ArcadeSeasonRankingPercent { get; set; }
    [Key(10)]
    public ArcadeSeasonEasterEggType ArcadeSeasonEasterEggFlags { get; set; }
}
