using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class BingoOpenPatternData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int PatternGroupUid { get; set; }
    [Key(2)]
    public int TilePosX { get; set; }
    [Key(3)]
    public int TilePosY { get; set; }
}
