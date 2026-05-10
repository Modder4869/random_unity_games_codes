using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class AchievementQuestData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public string TextKey { get; set; }
    [Key(2)]
    public int Sort { get; set; }
    [Key(3)]
    public int PrevQuestUid { get; set; }
    [Key(4)]
    public QuestType QuestType { get; set; }
    [Key(5)]
    public int[] Values { get; set; }
    [Key(6)]
    public int Group { get; set; }
    [Key(7)]
    public string DescKey { get; set; }
    [Key(8)]
    public AchieveCategoryType AchieveCategoryType { get; set; }
}
