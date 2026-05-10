using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserSetData {
    [Key(0)]
    public int Step { get; set; }
}
