using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserNpcData {
    [Key(0)]
    public int SkinId { get; set; }
}
