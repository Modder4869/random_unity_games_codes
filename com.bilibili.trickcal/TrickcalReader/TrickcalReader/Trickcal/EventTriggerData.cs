using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class EventTriggerData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public TriggerCheckType[] TriggerCheckType { get; set; }
    [Key(2)]
    public int[] TriggerCheckValue { get; set; }
    [Key(3)]
    public int[] TriggerCheckExtraValue { get; set; }
    [Key(4)]
    public int RemainHourValue { get; set; }
    [Key(5)]
    public int MaxCount { get; set; }
}
