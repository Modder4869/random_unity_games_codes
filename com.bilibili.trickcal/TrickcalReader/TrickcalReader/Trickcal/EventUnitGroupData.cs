using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class EventUnitGroupData : TableItem<TableData> {
    [Key(0)]
    public int GroupUid { get; set; }
    [Key(1)]
    public int UnitUid { get; set; }
}
