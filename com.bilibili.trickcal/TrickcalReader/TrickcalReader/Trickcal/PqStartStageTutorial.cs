using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqStartStageTutorial {
    [Key(0)]
    public int StageUid { get; set; }
    [Key(1)]
    public PlayDeckData PlayDeckData { get; set; }
    [Key(2)]
    public StagePowerData PowerData { get; set; }
    [Key(3)]
    public bool IsAutoPlay { get; set; }
}
