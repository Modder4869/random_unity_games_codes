using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ThemeEventData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int WorldUid { get; set; }
    [Key(2)]
    public int BonusHeroGroupUid { get; set; }
    [Key(3)]
    public int EventShopUid { get; set; }
    [Key(4)]
    public int EventQuestUid { get; set; }
    [Key(5)]
    public int QuestInteractionGroup { get; set; }
    [Key(6)]
    public int ChapterUid { get; set; }
    [Key(7)]
    public int EventCurrencyItemUid { get; set; }
    [Key(8)]
    public int HardOpenStageUid { get; set; }
    [Key(9)]
    public int VeryHardOpenStageUid { get; set; }
    [Key(10)]
    public string TitleText { get; set; }
    [Key(11)]
    public string TitleImage { get; set; }
    [Key(12)]
    public string BackgroundVideo { get; set; }
    [Key(13)]
    public string StoryButton { get; set; }
    [Key(14)]
    public string BattleButton { get; set; }
    [Key(15)]
    public int PreviewUid { get; set; }
    [Key(16)]
    public int HighlightEpisodeUid { get; set; }
    [Key(17)]
    public string Highlight { get; set; }
    [Key(18)]
    public string ShopButton { get; set; }
    [Key(19)]
    public string PrologueButton { get; set; }
    [Key(20)]
    public string QuestBackGround { get; set; }
    [Key(22)]
    public int PickUpUid { get; set; }
    [Key(23)]
    public string PeriodColor { get; set; }
    [Key(24)]
    public string TitleImageFX { get; set; }
    [Key(25)]
    public int MiniGameUid { get; set; }
    [Key(26)]
    public ContentsUnlockType MiniGameUnlockType { get; set; }
    [Key(27)]
    public int MiniGameUnlockValue { get; set; }
    [Key(28)]
    public string MiniGameButton { get; set; }
    [Key(29)]
    public int ChallengeOpenStageUid { get; set; }
    [Key(30)]
    public string ChallengeButton { get; set; }
    [Key(31)]
    public string BGM1 { get; set; }
    [Key(32)]
    public string BGM2 { get; set; }
    [Key(33)]
    public ThemeEventConceptType ThemeEventConcept { get; set; }
    [Key(34)]
    public int HelpUid { get; set; }
    [Key(35)]
    public int HardOpenDelayHours { get; set; }
    [Key(36)]
    public int VeryHardOpenDelayHours { get; set; }
    [Key(37)]
    public int ChallengeOpenDelayHours { get; set; }
    [Key(38)]
    public int LobbyInfoUid { get; set; }
}
