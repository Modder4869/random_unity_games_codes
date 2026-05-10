using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqBetWWEMatch {
    [Key(0)]
    public int SeasonId { get; set; }
    [Key(1)]
    public int MatchId { get; set; }
    [Key(2)]
    public TeamType BetTeamType { get; set; }
}
