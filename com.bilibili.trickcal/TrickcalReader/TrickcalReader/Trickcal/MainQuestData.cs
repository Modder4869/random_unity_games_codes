using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class MainQuestData : TableItem<TableData> {
    [Key(0)]
    public TableBaseQuestData QuestData { get; set; }
    [Key(1)]
    public MainQuestReceiveRewardType ReceiveReward { get; set; }
}
