using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestVotingEventForceSync {
    [Key(0)]
    public int MixedEventUid { get; set; }
}
