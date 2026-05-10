using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTileEventOpenTile {
    [Key(0)]
    public int MixedEventUid { get; set; }
    [Key(1)]
    public int TileUid { get; set; }
}
