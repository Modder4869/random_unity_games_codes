using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public struct UserRecordEventKey {
    [Key(0)]
    public MigrationType Migration { get; set; }
    [Key(1)]
    public TrackingType Tracking { get; set; }
}
