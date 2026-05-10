using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class AlbumStoryUnitGroupData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int TargetUnitUid { get; set; }
    [Key(2)]
    public int[] UnitUid { get; set; }
}
