using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqVotingEventSelectTeam {
    [Key(0)]
    public int MixedEventUid { get; set; }
    [Key(2)]
    public VotingEventTeamType Team { get; set; }
}
