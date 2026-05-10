using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqRunFunctionMiniGame {
    [Key(0)]
    public int MiniGameUid { get; set; }
    [Key(1)]
    public IMiniGameFunctionData FunctionData { get; set; }
}
