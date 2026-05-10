using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrVotingEventGetInfo {
    [Key(0)]
    public VotingEventState State { get; set; }
    [Key(1)]
    public int Day { get; set; }
    [Key(2)]
    public VotingEventTeamType[] Winners { get; set; }
    [Key(3)]
    public Dictionary<VotingEventTeamType, long> Votes { get; set; }
}
