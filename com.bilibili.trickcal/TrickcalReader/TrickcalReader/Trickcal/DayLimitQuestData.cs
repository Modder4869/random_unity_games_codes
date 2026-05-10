using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class DayLimitQuestData : TableItem<TableData> {
    [Key(0)]
    public TableBaseQuestData QuestData { get; set; }
    [Key(1)]
    public int EventUid { get; set; }
    [Key(2)]
    public int Day { get; set; }
    [Key(3)]
    public int Point { get; set; }
}
