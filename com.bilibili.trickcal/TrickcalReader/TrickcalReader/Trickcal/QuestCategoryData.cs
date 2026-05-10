using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class QuestCategoryData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public QuestCategoryType QuestType { get; set; }
    [Key(2)]
    public QuestCategoryTabType MainTab { get; set; }
    [Key(3)]
    public int MainTabSort { get; set; }
}
