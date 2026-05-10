using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserWorldTowerData {
    [Key(0)]
    public int LastClearStageUid { get; set; }
    [Key(1)]
    public int LastRewardStageUid { get; set; }
    [Key(2)]
    public DateTime SelectTime { get; set; }
}
