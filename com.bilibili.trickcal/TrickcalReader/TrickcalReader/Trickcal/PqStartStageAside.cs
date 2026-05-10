using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqStartStageAside {
    [Key(0)]
    public int StageUid { get; set; }
    [Key(1)]
    public PlayDeckData PlayDeckData { get; set; }
    [Key(2)]
    public bool IsAutoPlay { get; set; }
}
