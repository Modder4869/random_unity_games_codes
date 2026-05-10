using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserRecallLimitData {
    [Key(0)]
    public DateTime StartTime { get; set; }
}
