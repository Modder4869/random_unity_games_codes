using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTournamentEventVote {
    [Key(0)]
    public int MixedEventUid { get; set; }
    [Key(1)]
    public List<TournamentRoundVote> VoteList { get; set; }
}
