using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrEndMiniGame {
    [Key(0)]
    public IMiniGameServerResultData MiniGameServerResultData { get; set; }
}
