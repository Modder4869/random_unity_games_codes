using MessagePack;
using System.Collections;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserData {
    [Key(0)]
    public string Name { get; set; }
    [Key(1)]
    public string Comment { get; set; }
    [Key(2)]
    public short Level { get; set; }
    [Key(3)]
    public int Exp { get; set; }
    [Key(4)]
    public int Gold { get; set; }
    [Key(5)]
    public int FreeCash { get; set; }
    [Key(6)]
    public int Cash { get; set; }
    [Key(7)]
    public int Stamina { get; set; }
    [Key(8)]
    public DateTime StaminaTime { get; set; }
    [Key(9)]
    public int ExpPoint { get; set; }
    [Key(10)]
    public int LastGlobalMailId { get; set; }
    [Key(11)]
    public int AttendanceDays { get; set; }
    [Key(12)]
    public int HeroGachaMileage { get; set; }
    [Key(13)]
    public int TutorialState { get; set; }
    [Key(14)]
    public int FreeMileage { get; set; }
    [Key(15)]
    public int PetFreeMileage { get; set; }
    [Key(16)]
    public DateTime LastDailyRefreshTime { get; set; }
    [Key(17)]
    public int SocialPoint { get; set; }
    [Key(18)]
    public int PickUpMileage { get; set; }
    [Key(19)]
    public short BeginnerQuestStep { get; set; }
    [Key(20)]
    public bool IsInviteTester { get; set; }
    [Key(21)]
    public int[] LoveHeroes { get; set; }
    [Key(22)]
    public DateTime[] LoveHeroCancelCoolTimes { get; set; }
    [Key(23)]
    public BitArray ReceivedHelpRewards { get; set; }
    [Key(24)]
    public DateTime CreateTime { get; set; }
    [Key(25)]
    public short Birthday { get; set; }
    [Key(26)]
    public DateTime ChangeNicknameCoolTime { get; set; }
    [Key(27)]
    public int ProfileIconId { get; set; }
    [Key(28)]
    public int ProfileBorderId { get; set; }
    [Key(29)]
    public int[] ProfileHeroes { get; set; }
    [Key(30)]
    public bool ProfileHideTrickcalRank { get; set; }
    [Key(31)]
    public int LastReceivedLevelReward { get; set; }
    [Key(32)]
    public int SummonsCardPoint { get; set; }
    [Key(33)]
    public int ModeStamina { get; set; }
    [Key(34)]
    public int DailyModeUpgradePlayCount { get; set; }
    [Key(35)]
    public int OverExpPoint { get; set; }
    [Key(36)]
    public int DailyModeEquipPartPlayCount { get; set; }
    [Key(37)]
    public string FriendCode { get; set; }
    [Key(38)]
    public int[] ClearedEvents { get; set; }
    [Key(39)]
    public int[] RepurchaseGuideCashShopIds { get; set; }
    [Key(40)]
    public int ProfileNameplateId { get; set; }
    [Key(41)]
    public bool IsMainLobbyRandom { get; set; }
    [Key(42)]
    public DateTime LastLobbyEventTime { get; set; }
    [Key(43)]
    public int LastGachaHistoryIndex { get; set; }
    [Key(44)]
    public int AsideStamina { get; set; }
    [Key(45)]
    public bool IsTutorialGachaCompleted { get; set; }
    [Key(46)]
    public ContentsType[] DismissedContentUnlocks { get; set; }
    [Key(47)]
    public int[] PlayingMixedEvents { get; set; }
    [Key(48)]
    public LanguageType Language { get; set; }
    [Key(49)]
    public BitArray CompletedExtraTutorialUids { get; set; }
    [Key(50)]
    public int[] PlayingGachaEvents { get; set; }
    [Key(51)]
    public int[] ReceivedRewardHeroMotionExperienceUids { get; set; }
    [Key(52)]
    public int[] ReceivedRewardPreviewEventUids { get; set; }
    [Key(53)]
    public int MainProfileHeroId { get; set; }
    [Key(54)]
    public int HighestPvpRanking { get; set; }
    [Key(55)]
    public DateTime LastBirthDayStartTime { get; set; }
    [Key(56)]
    public EventType[] PlayingEventTypes { get; set; }
    [Key(57)]
    public int[] PlayingEventUids { get; set; }
    [Key(58)]
    public bool IsStageAutoPlay { get; set; }
    [Key(59)]
    public int[] AutoPlayedStageUids { get; set; }
    [Key(60)]
    public StageClearType[] AutoPlayedStageClearTypes { get; set; }
    [Key(61)]
    public int AutoPlayStartExp { get; set; }
    [Key(62)]
    public OneSdkAccountBindingType BindingType { get; set; }
    [Key(63)]
    public int ProfileNameStyleId { get; set; }
    [Key(64)]
    public int[] EventFirstDayLogin { get; set; }
}
