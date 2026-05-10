using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SoloEndQuestData : TableItem<TableData> {
    [Key(0)]
    public TableBaseQuestData QuestData { get; set; }
    [Key(1)]
    public int AchievementGroup { get; set; }
    [Key(2)]
    public QuestCategoryType Type { get; set; }
}
