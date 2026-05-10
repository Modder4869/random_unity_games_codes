using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqVotingEventVote {
    [Key(0)]
    public int MixedEventUid { get; set; }
    [Key(1)]
    public int Count { get; set; }
}
