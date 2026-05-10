using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class AlbumUnlockData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public AlbumType AlbumType { get; set; }
    [Key(2)]
    public AlbumDataType DataType { get; set; }
    [Key(3)]
    public AlbumDataUnlockType UnlockType { get; set; }
    [Key(4)]
    public int UnlockValue { get; set; }
}
