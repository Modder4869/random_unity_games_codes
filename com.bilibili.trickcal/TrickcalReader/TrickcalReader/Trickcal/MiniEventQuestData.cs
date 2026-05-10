using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class MiniEventQuestData : TableItem<TableData> {
    [Key(0)]
    public TableBaseQuestData QuestData { get; set; }
    [Key(1)]
    public int MiniEventQuestGroupUid { get; set; }
    [Key(2)]
    public QuestCategoryType Type { get; set; }
    [Key(3)]
    public int AchievementGroup { get; set; }
}
