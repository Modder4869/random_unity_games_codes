using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TowerBattleEndResultData {
    [Key(0)]
    public int SeasonId { get; set; }
    [Key(1)]
    public string MatchId { get; set; }
    [Key(2)]
    public int UserId { get; set; }
    [Key(3)]
    public TowerBattleResultType ResultType { get; set; }
    [Key(4)]
    public int OpponentUserId { get; set; }
    [Key(5)]
    public int OpponentUserScore { get; set; }
    [Key(6)]
    public int ObjectCount { get; set; }
}
