using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class LotteryEventQuestData : TableItem<TableData> {
    [Key(0)]
    public TableBaseQuestData QuestData { get; set; }
    [Key(1)]
    public int GroupUid { get; set; }
    [Key(2)]
    public int AchievementGroupUid { get; set; }
    [Key(3)]
    public QuestCategoryType Type { get; set; }
    [Key(4)]
    public int CategoryUid { get; set; }
}
