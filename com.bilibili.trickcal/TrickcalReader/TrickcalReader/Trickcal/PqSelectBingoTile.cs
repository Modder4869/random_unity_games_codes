using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqSelectBingoTile {
    [Key(0)]
    public int BingoEventUid { get; set; }
    [Key(1)]
    public int TileLocationIndex { get; set; }
}
