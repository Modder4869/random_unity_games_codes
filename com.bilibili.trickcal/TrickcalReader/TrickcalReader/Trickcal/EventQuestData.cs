using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class EventQuestData : TableItem<TableData> {
    [Key(0)]
    public TableBaseQuestData QuestData { get; set; }
    [Key(1)]
    public int GroupUid { get; set; }
    [Key(2)]
    public QuestCategoryType Type { get; set; }
    [Key(3)]
    public QuestCategorySubType SubType { get; set; }
    [Key(4)]
    public int AchievementGroup { get; set; }
    [Key(5)]
    public int Category { get; set; }
    [Key(6)]
    public bool IsThemeFinalize { get; set; }
}
