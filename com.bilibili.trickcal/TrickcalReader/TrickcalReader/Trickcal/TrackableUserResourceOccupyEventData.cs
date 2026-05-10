using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserResourceOccupyEventData {
    [Key(0)]
    public DateTime GenerationStartTime { get; set; }
    [Key(1)]
    public int StarCount { get; set; }
    [Key(2)]
    public DateTime[] StageClearTimes { get; set; }
    [Key(3)]
    public int[] StarCountChanges { get; set; }
}
