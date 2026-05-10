using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqOpenPointConsumeEventStep {
    [Key(0)]
    public int MixedEventUid { get; set; }
    [Key(1)]
    public int StepGroup { get; set; }
    [Key(2)]
    public int Step { get; set; }
}
