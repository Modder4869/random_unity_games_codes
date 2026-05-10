using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableGuildContext {
    [Key(0)]
    public TrackableGuildData Guild { get; set; }
    [Key(1)]
    public TrackablePocoDictionary<int, IGuildMemberData> Members { get; set; }
    [Key(2)]
    public TrackablePocoDictionary<int, IGuildJoinRequestData> JoinRequests { get; set; }
}
