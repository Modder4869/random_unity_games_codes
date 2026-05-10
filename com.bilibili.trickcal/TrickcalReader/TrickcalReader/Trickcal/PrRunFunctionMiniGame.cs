using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrRunFunctionMiniGame {
    [Key(0)]
    public IMiniGameServerResultData MiniGameServerResultData { get; set; }
}
