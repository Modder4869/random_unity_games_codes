using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqDeductionEventSetIntroWatched {
    [Key(0)]
    public int MixedEventUid { get; set; }
    [Key(1)]
    public int Round { get; set; }
}
