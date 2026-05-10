using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class HomeEventInfoData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int Sort { get; set; }
    [Key(2)]
    public HomeEventConditionType[] StartConditionTypes { get; set; }
    [Key(3)]
    public int[] StartConditionValues { get; set; }
    [Key(4)]
    public int HomeEventGroup { get; set; }
    [Key(5)]
    public HomeEventGroupType HomeEventGroupType { get; set; }
    [Key(6)]
    public int DailyMax { get; set; }
    [Key(7)]
    public HomeEventTriggerType StartTriggerType { get; set; }
    [Key(8)]
    public int StartTriggerValue { get; set; }
}
