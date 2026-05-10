using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserAreaChallengeData {
    [Key(0)]
    public int CurrentStageUid { get; set; }
    [Key(1)]
    public short MaxClearedStageWave { get; set; }
    [Key(2)]
    public int LastPlayedStageUid { get; set; }
    [Key(3)]
    public int[] SelectableAugmentUids { get; set; }
    [Key(4)]
    public int[] SelectedAugmentUids { get; set; }
}
