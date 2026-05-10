using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public struct EventKey {
    [Key(0)]
    public EventType Type { get; set; }
    [Key(1)]
    public int Uid { get; set; }
}
