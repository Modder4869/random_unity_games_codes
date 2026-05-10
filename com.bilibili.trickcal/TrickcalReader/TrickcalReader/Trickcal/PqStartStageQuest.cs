using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqStartStageQuest {
    [Key(0)]
    public int StageUid { get; set; }
    [Key(1)]
    public PlayDeckData PlayDeckData { get; set; }
    [Key(2)]
    public StagePowerData PowerData { get; set; }
    [Key(3)]
    public bool IsAutoPlay { get; set; }
    [Key(4)]
    public bool IsFastBattle { get; set; }
}
