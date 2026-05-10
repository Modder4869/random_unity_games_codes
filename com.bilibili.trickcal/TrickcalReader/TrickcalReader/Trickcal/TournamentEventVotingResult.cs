using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TournamentEventVotingResult {
    [Key(0)]
    public int TotalVoteCount { get; set; }
    [Key(1)]
    public int TotalMatchCount { get; set; }
    [Key(2)]
    public Dictionary<int, int> MatchWinCountMap { get; set; }
    [Key(3)]
    public Dictionary<int, int> FinalWinCountMap { get; set; }
}
