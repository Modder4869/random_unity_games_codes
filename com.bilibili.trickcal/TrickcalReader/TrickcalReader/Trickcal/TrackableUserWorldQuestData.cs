using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserWorldQuestData {
    [Key(0)]
    public int LastClearStageUid { get; set; }
    [Key(1)]
    public WorldRewardState[] WorldStates { get; set; }
    [Key(2)]
    public StageClearState[] StageStates { get; set; }
}
