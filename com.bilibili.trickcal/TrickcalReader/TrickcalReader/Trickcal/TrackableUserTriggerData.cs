using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserTriggerData {
    [Key(0)]
    public DateTime LastActivationTime { get; set; }
    [Key(1)]
    public int ActivationCount { get; set; }
}
