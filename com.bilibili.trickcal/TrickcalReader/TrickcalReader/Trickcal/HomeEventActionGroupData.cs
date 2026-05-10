using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class HomeEventActionGroupData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int Group { get; set; }
    [Key(2)]
    public HomeEventConditionType[] ConditionTypes { get; set; }
    [Key(3)]
    public int[] ConditionValues { get; set; }
    [Key(4)]
    public HomeEventActionType ActionType { get; set; }
    [Key(5)]
    public string[] ActionParams { get; set; }
}
