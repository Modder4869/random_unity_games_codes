using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class AlbumStepUp : TableItem<TableData> {
    [Key(0)]
    public int Step { get; set; }
    [Key(1)]
    public AlbumType AlbumType { get; set; }
    [Key(2)]
    public int[] NeedCountGrade { get; set; }
}
