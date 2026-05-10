using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserRecordData {
    [Key(0)]
    public int LastReceivedRecordReward { get; set; }
}
