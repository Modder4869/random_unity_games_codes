using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqReceiveAllAchievementRewards {
    [Key(0)]
    public QuestCategoryKey QuestCategoryKey { get; set; }
    [Key(1)]
    public AchieveCategoryType AchievementCategoryType { get; set; }
    [Key(2)]
    public int ThemeEventUid { get; set; }
    [Key(3)]
    public int DayLimitQuestEventUid { get; set; }
    [Key(4)]
    public int MiniEventUid { get; set; }
    [Key(5)]
    public int MiniEventQuestGroupUid { get; set; }
    [Key(6)]
    public int MiniGameQuestGroupUid { get; set; }
    [Key(7)]
    public int EventQuestGroupUid { get; set; }
    [Key(8)]
    public int AnniversaryEventUid { get; set; }
    [Key(9)]
    public int TowerBattleQuestGroupUid { get; set; }
}
