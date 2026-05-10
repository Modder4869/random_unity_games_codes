using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableGuildJoinRequestData {
    [Key(0)]
    public DateTime RequestTime { get; set; }
}
