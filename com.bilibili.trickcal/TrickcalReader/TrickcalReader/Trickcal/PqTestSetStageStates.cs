using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestSetStageStates {
    [Key(0)]
    public int StageUid { get; set; }
    [Key(1)]
    public StageClearState ClearState { get; set; }
}
