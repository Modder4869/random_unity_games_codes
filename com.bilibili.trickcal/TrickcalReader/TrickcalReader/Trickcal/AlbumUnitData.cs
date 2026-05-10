using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class AlbumUnitData : TableItem<TableData> {
    [Key(0)]
    public int AlbumUid { get; set; }
    [Key(1)]
    public AlbumDataType DataType { get; set; }
    [Key(2)]
    public string DataText { get; set; }
}
