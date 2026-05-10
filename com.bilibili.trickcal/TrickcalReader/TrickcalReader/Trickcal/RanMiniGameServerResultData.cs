using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class RanMiniGameServerResultData {
    [Key(0)]
    public int? Ending { get; set; }
}
