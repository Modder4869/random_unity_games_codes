using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserLotteryEventData {
    [Key(0)]
    public int Round { get; set; }
    [Key(1)]
    public int LoopCount { get; set; }
    [Key(2)]
    public int TotalDrawCount { get; set; }
    [Key(3)]
    public int[] PickedLimitedUids { get; set; }
    [Key(4)]
    public int[] PickedLimitedCounts { get; set; }
}
