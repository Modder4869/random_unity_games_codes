using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqReceiveVotingEventReward {
    [Key(0)]
    public int MixedEventUid { get; set; }
}
