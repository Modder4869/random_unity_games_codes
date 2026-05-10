using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class AutoReceiveQuestData : TableItem<TableData> {
    [Key(0)]
    public TableBaseQuestData QuestData { get; set; }
    [Key(1)]
    public bool NavigationExist { get; set; }
    [Key(2)]
    public AutoReceiveQuestReceiveSceneType ReceiveScene { get; set; }
}
