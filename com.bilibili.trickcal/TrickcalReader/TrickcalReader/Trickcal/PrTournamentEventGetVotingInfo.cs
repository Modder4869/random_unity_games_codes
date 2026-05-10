using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrTournamentEventGetVotingInfo {
    [Key(0)]
    public TournamentEventVotingResult TournamentEventVotingResult { get; set; }
}
