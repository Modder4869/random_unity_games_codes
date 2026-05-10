using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserFriendRequestData {
    [Key(0)]
    public DateTime RequestTime { get; set; }
}
