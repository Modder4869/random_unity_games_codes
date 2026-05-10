using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserItemData {
    [Key(0)]
    public int Count { get; set; }
}
