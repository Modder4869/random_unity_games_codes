using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqVotingEventGetInfo {
    [Key(0)]
    public int MixedEventUid { get; set; }
}
