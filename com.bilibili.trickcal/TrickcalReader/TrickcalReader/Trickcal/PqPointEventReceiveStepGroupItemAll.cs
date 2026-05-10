using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqPointEventReceiveStepGroupItemAll {
    [Key(0)]
    public int MixedEventUid { get; set; }
    [Key(1)]
    public int StepGroup { get; set; }
}
