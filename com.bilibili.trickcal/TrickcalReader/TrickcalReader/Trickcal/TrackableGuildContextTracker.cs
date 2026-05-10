using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableGuildContextTracker {
    [Key(0)]
    public TrackableContainerInnerTracker<TrackablePocoTracker<IGuildData>, IGuildData> SerializableGuild { get; set; }
    [Key(1)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, IGuildMemberData>, TrackablePocoDictionary<int, IGuildMemberData>> SerializableMembers { get; set; }
    [Key(2)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, IGuildJoinRequestData>, TrackablePocoDictionary<int, IGuildJoinRequestData>> SerializableJoinRequests { get; set; }
}
