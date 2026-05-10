using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class RanEditionMiniGameServerResultData {
    [Key(0)]
    public int? Ending { get; set; }
}
