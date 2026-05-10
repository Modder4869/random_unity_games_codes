using MessagePack;
using System.Collections;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserVotingEventData {
    [Key(0)]
    public VotingEventTeamType CurrentTeam { get; set; }
    [Key(1)]
    public VotingEventTeamType[] SelectedTeamHistory { get; set; }
    [Key(2)]
    public BitArray IsVoted { get; set; }
    [Key(3)]
    public BitArray ReceivedRewards { get; set; }
    [Key(4)]
    public int[] VotedAmount { get; set; }
}
