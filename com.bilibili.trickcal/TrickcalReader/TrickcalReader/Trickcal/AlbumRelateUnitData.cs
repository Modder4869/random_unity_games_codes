using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class AlbumRelateUnitData : TableItem<TableData> {
    [Key(0)]
    public int AlbumUid { get; set; }
    [Key(1)]
    public int Step { get; set; }
    [Key(2)]
    public int UnitUid { get; set; }
    [Key(3)]
    public int Distance { get; set; }
    [Key(4)]
    public AlbumRelateSizeType Size { get; set; }
}
