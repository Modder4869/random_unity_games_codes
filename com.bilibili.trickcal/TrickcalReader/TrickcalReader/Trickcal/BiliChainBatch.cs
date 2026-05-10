using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class BiliChainBatch {
    [Key(0)]
    public int CurrentBatch { get; set; }
    [Key(1)]
    public DateTime CurrentStartTime { get; set; }
    [Key(2)]
    public DateTime CurrentEndTime { get; set; }
    [Key(3)]
    public int NextBatch { get; set; }
    [Key(4)]
    public DateTime NextStartTime { get; set; }
    [Key(5)]
    public DateTime NextEndTime { get; set; }
}
