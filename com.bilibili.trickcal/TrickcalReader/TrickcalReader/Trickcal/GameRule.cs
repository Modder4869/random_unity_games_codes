using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class GameRule {
    [Key(0)]
    public string InitUserName { get; set; }
    [Key(1)]
    public string InitUserComment { get; set; }
    [Key(2)]
    public int InitGold { get; set; }
    [Key(3)]
    public int InitCash { get; set; }
    [Key(5)]
    public int InitExpPoint { get; set; }
    [Key(6)]
    public int[] InitHeroArray { get; set; }
    [Key(7)]
    public string InitDeckName { get; set; }
    [Key(8)]
    public int InitDeckHero0 { get; set; }
    [Key(9)]
    public int InitDeckHero1 { get; set; }
    [Key(10)]
    public int InitDeckHero2 { get; set; }
    [Key(11)]
    public int InitDeckHero3 { get; set; }
    [Key(12)]
    public int InitDeckHero4 { get; set; }
    [Key(13)]
    public int InitDeckHero5 { get; set; }
    [Key(14)]
    public Goods[] InitGoodsArray { get; set; }
    [Key(18)]
    public int InitFreeCash { get; set; }
    [Key(19)]
    public int StageModeTicketCount { get; set; }
    [Key(20)]
    public TimeSpan GlobalMailReadyTime { get; set; }
    [Key(21)]
    public TimeSpan DefaultMailExpireTime { get; set; }
    [Key(22)]
    public TimeSpan UserNamePreemptTime { get; set; }
    [Key(23)]
    public int MailHistoryMaxCount { get; set; }
    [Key(24)]
    public TimeSpan MailHistoryExpireTime { get; set; }
    [Key(26)]
    public int NameLengthMin { get; set; }
    [Key(27)]
    public int NameLengthMax { get; set; }
    [Key(28)]
    public int SkipCountLimit { get; set; }
    [Key(30)]
    public TimeSpan UserSessionExpireTime { get; set; }
    [Key(31)]
    public TimeSpan GmAuthTokenExpireTime { get; set; }
    [Key(32)]
    public int MyHomeHousingPresetCount { get; set; }
    [Key(34)]
    public int InitTutorialState { get; set; }
    [Key(35)]
    public TimeSpan MonthlyTimeInterval { get; set; }
    [Key(36)]
    public int MailMaxCount { get; set; }
    [Key(37)]
    public int TrickcalRankRecordMaxCount { get; set; }
    [Key(38)]
    public int TrickcalRankRewardBoxMaxCount { get; set; }
    [Key(39)]
    public int TrickcalRankHeroDataLength { get; set; }
    [Key(40)]
    public int FriendRecommendGroupCount { get; set; }
    [Key(41)]
    public int FriendRecommendGroupUserCount { get; set; }
    [Key(42)]
    public int CommentLengthMin { get; set; }
    [Key(43)]
    public int CommentLengthMax { get; set; }
    [Key(44)]
    public int InitProfileIcon { get; set; }
    [Key(45)]
    public int DeckNameLengthMin { get; set; }
    [Key(46)]
    public int DeckNameLengthMax { get; set; }
    [Key(47)]
    public int MyHomePresetNameLengthMin { get; set; }
    [Key(48)]
    public int MyHomePresetNameLengthMax { get; set; }
    [Key(49)]
    public int GlobalInitTutorialState { get; set; }
}
