using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class EventUnitGradeData : TableItem<TableData> {
    [Key(0)]
    public int UnitUid { get; set; }
    [Key(1)]
    public int Grade { get; set; }
    [Key(2)]
    public EventUnitGradeCondition[] Conditions { get; set; }
    [Key(3)]
    public int[] Values { get; set; }
    [Key(4)]
    public string BattleSkin { get; set; }
}
