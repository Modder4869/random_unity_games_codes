using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqStartMiniGame {
    [Key(0)]
    public int MiniGameUid { get; set; }
    [Key(1)]
    public int MiniGameStageUid { get; set; }
}
