using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqEnterMixedEventFirst {
    [Key(0)]
    public int MixedEventUid { get; set; }
}
