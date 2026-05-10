using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class OperationDataContext {
    [Key(0)]
    public DateTime CreateTime { get; set; }
    [Key(1)]
    public CashShopOperationDataContext CashShop { get; set; }
    [Key(2)]
    public PassOperationDataContext Pass { get; set; }
    [Key(3)]
    public AttendanceDailyOperationDataContext AttendanceDaily { get; set; }
    [Key(4)]
    public HeroGachaPickUpOperationDataContext HeroGachaPickUp { get; set; }
    [Key(5)]
    public SpectacleCardOperationDataContext SpectacleCard { get; set; }
    [Key(6)]
    public EventOperationDataContext Event { get; set; }
    [Key(7)]
    public ThemeEventOperationDataContext ThemeEvent { get; set; }
    [Key(8)]
    public DayLimitQuestOperationDataContext DayLimitQuest { get; set; }
    [Key(9)]
    public MiniEventOperationDataContext MiniEvent { get; set; }
    [Key(10)]
    public ContentsMaintenanceOperationDataContext ContentsMaintenance { get; set; }
    [Key(11)]
    public DropEventOperationDataContext DropEvent { get; set; }
    [Key(12)]
    public PvpScheduleOperationDataContext PvpSchedule { get; set; }
    [Key(13)]
    public BingoEventOperationDataContext BingoEvent { get; set; }
    [Key(14)]
    public SoloEndScheduleOperationDataContext SoloEndSchedule { get; set; }
    [Key(15)]
    public SoloRaidScheduleOperationDataContext SoloRaidSchedule { get; set; }
    [Key(16)]
    public LobbyEventOperationDataContext LobbyEvent { get; set; }
    [Key(17)]
    public PetDispatchScheduleOperationDataContext PetDispatchSchedule { get; set; }
    [Key(18)]
    public MixedEventOperationDataContext MixedEvent { get; set; }
    [Key(19)]
    public AccountReturnEventOperationDataContext AccountReturnEvent { get; set; }
    [Key(20)]
    public UserLvPassOperationDataContext UserLvPass { get; set; }
    [Key(21)]
    public AnniversaryPageOperationDataContext AnniversaryPage { get; set; }
    [Key(22)]
    public DailyTimeEventOperationDataContext DailyTimeEvent { get; set; }
    [Key(23)]
    public HeroMotionExperienceOperationDataContext HeroMotionExperience { get; set; }
    [Key(24)]
    public PreviewEventOperationDataContext PreviewEvent { get; set; }
    [Key(25)]
    public CardGachaPickUpOperationDataContext CardGachaPickUp { get; set; }
    [Key(26)]
    public TitleHeroSettingOperationDataContext TitleHeroSetting { get; set; }
    [Key(27)]
    public DiscountEventOperationDataContext DiscountEvent { get; set; }
    [Key(28)]
    public RecallScheduleOperationDataContext Recall { get; set; }
    [Key(29)]
    public HeroGrowEventOperationDataContext HeroGrowEvent { get; set; }
    [Key(30)]
    public ChaosArenaScheduleOperationDataContext ChaosArenaSchedule { get; set; }
    [Key(31)]
    public GachaponEventOperationDataContext GachaponEvent { get; set; }
    [Key(32)]
    public CookingTycoonScheduleOperationDataContext CookingTycoonSchedule { get; set; }
    [Key(33)]
    public WWEScheduleOperationDataContext WWESchedule { get; set; }
    [Key(34)]
    public ArcadeSeasonScheduleOperationDataContext ArcadeSeasonSchedule { get; set; }
    [Key(35)]
    public TowerBattleScheduleOperationDataContext TowerBattleSchedule { get; set; }
    [Key(36)]
    public PuppetEventScheduleOperationDataContext PuppetEventSchedule { get; set; }
    [Key(37)]
    public WebLinkEventOperationDataContext WebLinkEvent { get; set; }
    [Key(38)]
    public BoostEventOperationDataContext BoostEvent { get; set; }
    [Key(39)]
    public StoryLockOverRideEventOperationDataContext StoryLockOverRideEvent { get; set; }
    [Key(41)]
    public ChainGiftOperationDataContext ChainGift { get; set; }
}
