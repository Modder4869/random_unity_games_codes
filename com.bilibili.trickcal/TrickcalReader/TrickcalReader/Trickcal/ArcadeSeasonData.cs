using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ArcadeSeasonData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int MiniGameUid { get; set; }
    [Key(2)]
    public int ShopMainCategoryUid { get; set; }
    [Key(3)]
    public int MiniGameDailyQuestGroupUid { get; set; }
    [Key(4)]
    public int QuestInteractionGroup { get; set; }
    [Key(5)]
    public string EasterEggSkin { get; set; }
    [Key(6)]
    public string LobbyConsoleSkeleton { get; set; }
    [Key(7)]
    public int MiniGameAchievementQuestGroupUid { get; set; }
    [Key(8)]
    public int HelpUid { get; set; }
    [Key(9)]
    public int ChapterUid { get; set; }
}
