using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class BingoTileInfoData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int Season { get; set; }
    [Key(2)]
    public int TileNumber { get; set; }
    [Key(4)]
    public int RewardUid { get; set; }
    [Key(5)]
    public int RewardValue { get; set; }
    [Key(6)]
    public int BingoPoint { get; set; }
}
