using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserDropEventData {
    [Key(0)]
    public DateTime StartTime { get; set; }
}
