using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqAllOpenBingoTile {
    [Key(0)]
    public int BingoEventUid { get; set; }
}
