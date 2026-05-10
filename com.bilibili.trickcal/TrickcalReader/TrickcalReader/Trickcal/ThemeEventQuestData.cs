using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ThemeEventQuestData : TableItem<TableData> {
    [Key(0)]
    public TableBaseQuestData QuestData { get; set; }
    [Key(1)]
    public int ThemeEventQuestGroupUid { get; set; }
    [Key(2)]
    public QuestCategoryType Type { get; set; }
    [Key(3)]
    public int AchievementGroup { get; set; }
}
