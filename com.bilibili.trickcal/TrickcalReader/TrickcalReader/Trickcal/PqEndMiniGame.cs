using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqEndMiniGame {
    [Key(0)]
    public int StagePlayKey { get; set; }
    [Key(1)]
    public int Score { get; set; }
    [Key(2)]
    public int ClearStage { get; set; }
    [Key(3)]
    public IMiniGameClientResultData MiniGameClientResultData { get; set; }
    [Key(4)]
    public bool IsClear { get; set; }
}
