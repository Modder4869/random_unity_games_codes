using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TileEventTileInfo : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int TileGroup { get; set; }
    [Key(2)]
    public int GridX { get; set; }
    [Key(3)]
    public int GridY { get; set; }
    [Key(4)]
    public int StepGroup { get; set; }
}
