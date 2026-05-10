using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserWorldModeBasicData {
    [Key(0)]
    public int LastClearStageUid { get; set; }
    [Key(1)]
    public StageClearState[] StageStates { get; set; }
}
