using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserWorldAsideData {
    [Key(0)]
    public int LastClearStageUid { get; set; }
}
