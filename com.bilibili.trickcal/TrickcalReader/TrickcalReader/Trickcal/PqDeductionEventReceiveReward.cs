using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqDeductionEventReceiveReward {
    [Key(0)]
    public int MixedEventUid { get; set; }
    [Key(1)]
    public int Round { get; set; }
}
