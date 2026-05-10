using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class DailyQuestData : TableItem<TableData> {
    [Key(0)]
    public TableBaseQuestData QuestData { get; set; }
    [Key(1)]
    public QuestPickType PickType { get; set; }
    [Key(2)]
    public int RewardPassPoint { get; set; }
}
