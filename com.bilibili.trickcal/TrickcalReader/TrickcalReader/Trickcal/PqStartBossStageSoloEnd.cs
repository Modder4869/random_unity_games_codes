using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqStartBossStageSoloEnd {
    [Key(0)]
    public int SoloEndId { get; set; }
    [Key(1)]
    public int StageId { get; set; }
    [Key(2)]
    public PlayDeckData PlayDeckData { get; set; }
    [Key(3)]
    public bool IsAutoPlay { get; set; }
}
