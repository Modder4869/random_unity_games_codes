using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserTileEventData {
    [Key(0)]
    public int[] OpenedTiles { get; set; }
}
