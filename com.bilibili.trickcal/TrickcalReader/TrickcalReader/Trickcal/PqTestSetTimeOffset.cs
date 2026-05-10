using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestSetTimeOffset {
    [Key(0)]
    public TimeSpan Offset { get; set; }
}
