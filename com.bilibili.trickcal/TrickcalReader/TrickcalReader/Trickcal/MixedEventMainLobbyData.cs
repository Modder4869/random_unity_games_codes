using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class MixedEventMainLobbyData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public MixedEventContentsType MainLobbyContentsType { get; set; }
    [Key(2)]
    public MixedEventContentsType LotteryContentsType { get; set; }
    [Key(3)]
    public MixedEventContentsType BattleContentsType { get; set; }
    [Key(4)]
    public MixedEventContentsType AchievementContentsType { get; set; }
    [Key(5)]
    public MixedEventContentsType ShopContentsType { get; set; }
    [Key(6)]
    public MixedEventContentsType PointEventContentsType { get; set; }
    [Key(7)]
    public MixedEventContentsType ChallengeContentsType { get; set; }
    [Key(8)]
    public MixedEventContentsType AuthoritySelectionContentsType { get; set; }
    [Key(9)]
    public string PeriodColor { get; set; }
    [Key(10)]
    public int HighlightEpisodeUid { get; set; }
    [Key(11)]
    public string Highlight { get; set; }
    [Key(12)]
    public string BackgroundVideo { get; set; }
    [Key(13)]
    public string BGM1 { get; set; }
    [Key(14)]
    public string BGM2 { get; set; }
    [Key(15)]
    public string CustomizedStoryStageClearUnlockDesc { get; set; }
    [Key(16)]
    public ContentsUnlockType BGMUnlockType { get; set; }
    [Key(17)]
    public int BGMUnlockValue { get; set; }
    [Key(18)]
    public MixedEventContentsType ScoreEventContentsType { get; set; }
    [Key(19)]
    public MixedEventContentsType HeroBonusContentsType { get; set; }
    [Key(20)]
    public MixedEventContentsType EventUnitGrowthContentsType { get; set; }
    [Key(21)]
    public MixedEventContentsType DeckEditContentsType { get; set; }
    [Key(22)]
    public MixedEventContentsType TileEventContentsType { get; set; }
    [Key(23)]
    public MixedEventContentsType SideStoryContentsType { get; set; }
    [Key(24)]
    public MixedEventContentsType DailyLotteryContentsType { get; set; }
    [Key(25)]
    public MixedEventContentsType HallOfFameContentsType { get; set; }
    [Key(26)]
    public int LoadingUnitGroupUid { get; set; }
    [Key(27)]
    public MixedEventContentsType IntroContentsType { get; set; }
    [Key(28)]
    public MixedEventContentsType UserSkillGrowthContentsType { get; set; }
    [Key(29)]
    public MixedEventContentsType CardEditContentsType { get; set; }
    [Key(30)]
    public MixedEventContentsType AssembleEventContentsType { get; set; }
    [Key(31)]
    public MixedEventContentsType StoryEventContentsType { get; set; }
    [Key(32)]
    public MixedEventContentsType ClientContentsType { get; set; }
    [Key(33)]
    public MixedEventContentsType TournamentContentsType { get; set; }
}
