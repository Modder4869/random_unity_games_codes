using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserGlobalWorldTowerData {
    [Key(0)]
    public int LastClearStageUid { get; set; }
}
