using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class BeginnerQuestData : TableItem<TableData> {
    [Key(0)]
    public TableBaseQuestData QuestData { get; set; }
    [Key(1)]
    public bool IsAccumulative { get; set; }
    [Key(2)]
    public int Step { get; set; }
    [Key(3)]
    public int Season { get; set; }
    [Key(4)]
    public int HelpUid { get; set; }
}
