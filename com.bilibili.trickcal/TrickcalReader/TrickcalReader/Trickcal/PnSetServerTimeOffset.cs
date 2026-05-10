using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PnSetServerTimeOffset {
    [Key(0)]
    public TimeSpan ServerTimeOffset { get; set; }
}
