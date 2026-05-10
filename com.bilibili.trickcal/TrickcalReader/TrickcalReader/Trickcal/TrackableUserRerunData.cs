using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserRerunData {
    [Key(0)]
    public int LastClearStageUid { get; set; }
    [Key(1)]
    public int LastHardClearStageUid { get; set; }
    [Key(2)]
    public int LastVeryHardClearStageUid { get; set; }
    [Key(3)]
    public int LastChallengeClearStageUid { get; set; }
    [Key(4)]
    public bool IsEarlyOpened { get; set; }
    [Key(5)]
    public bool IsEntered { get; set; }
}
