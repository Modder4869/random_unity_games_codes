using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserHomeEventData {
    [Key(0)]
    public DateTime StartTime { get; set; }
    [Key(1)]
    public bool IsSuccess { get; set; }
    [Key(2)]
    public int ActivationCount { get; set; }
}
