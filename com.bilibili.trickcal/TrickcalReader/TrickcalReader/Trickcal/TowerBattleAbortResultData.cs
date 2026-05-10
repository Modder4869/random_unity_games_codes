using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TowerBattleAbortResultData {
    [Key(0)]
    public int SeasonId { get; set; }
    [Key(1)]
    public string MatchId { get; set; }
    [Key(2)]
    public int OpponentUserId { get; set; }
    [Key(3)]
    public int OpponentUserScore { get; set; }
    [Key(4)]
    public int DisconnectedUserId { get; set; }
}
