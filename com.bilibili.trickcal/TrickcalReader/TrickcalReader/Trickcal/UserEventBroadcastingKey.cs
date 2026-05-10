using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public struct UserEventBroadcastingKey {
    [Key(0)]
    public BroadcastingType Type { get; set; }
    [Key(1)]
    public int Condition { get; set; }
}
