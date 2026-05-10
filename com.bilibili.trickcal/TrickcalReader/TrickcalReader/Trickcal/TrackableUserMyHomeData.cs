using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserMyHomeData {
    [Key(0)]
    public short HomeLevel { get; set; }
    [Key(1)]
    public int HomeExp { get; set; }
    [Key(2)]
    public short DonationLevel { get; set; }
    [Key(3)]
    public DateTime DonationStartTime { get; set; }
    [Key(4)]
    public int DonationRewardSeed { get; set; }
    [Key(5)]
    public int DonationStartLabResearchUid { get; set; }
    [Key(6)]
    public int LastFoodEatHeroId { get; set; }
    [Key(7)]
    public int LastFoodEatEpisodeId { get; set; }
    [Key(8)]
    public short ScheduleLevel { get; set; }
    [Key(9)]
    public short TodayScheduleCount { get; set; }
    [Key(10)]
    public int ScheduleHeroId { get; set; }
    [Key(11)]
    public int[] SelectedScheduleTasks { get; set; }
    [Key(12)]
    public LifeTaskResultType[] SelectedScheduleTaskStates { get; set; }
    [Key(13)]
    public int[] PickableScheduleTasks { get; set; }
    [Key(14)]
    public int[] PickableScheduleSkills { get; set; }
    [Key(15)]
    public int[] ScheduleRewardItemIds { get; set; }
    [Key(16)]
    public int[] ScheduleRewardItemCounts { get; set; }
    [Key(17)]
    public int[] ScheduleRewardPerfectBonusIndexes { get; set; }
    [Key(18)]
    public int[] ScheduleItemEventItemIds { get; set; }
    [Key(19)]
    public int[] ScheduleItemEventItemCounts { get; set; }
    [Key(20)]
    public int[] Pets { get; set; }
    [Key(21)]
    public MyHomeBuildingType[] PetPositions { get; set; }
    [Key(22)]
    public short PetRewardBits { get; set; }
    [Key(23)]
    public short ProductionLabLevel { get; set; }
    [Key(28)]
    public int CurrentLabResearchUid { get; set; }
    [Key(29)]
    public DateTime LabResearchStartTime { get; set; }
    [Key(30)]
    public DateTime LabResearchCompleteTime { get; set; }
    [Key(31)]
    public short RestaurantLevel { get; set; }
    [Key(32)]
    public short ArchiveLevel { get; set; }
    [Key(37)]
    public int LifeResetHeroId { get; set; }
    [Key(38)]
    public int[] HousingLayouts { get; set; }
    [Key(39)]
    public int[] MyHomeReceivedRewardPetIds { get; set; }
    [Key(40)]
    public int AutoLabResearchStartUid { get; set; }
    [Key(41)]
    public bool IsAutoResearchEnabled { get; set; }
    [Key(42)]
    public AutoResearchContinueResult AutoResearchStopReason { get; set; }
    [Key(43)]
    public bool IsResearchCompletedByAuto { get; set; }
    [Key(44)]
    public int[] ScheduleUsedHeroIds { get; set; }
    [Key(45)]
    public int CurrentScheduleEpisodeId { get; set; }
    [Key(46)]
    public int[] DonationStartDropIds { get; set; }
    [Key(47)]
    public bool[] DonationStartLabApplys { get; set; }
    [Key(48)]
    public int DonationHiddenRewardCounter { get; set; }
    [Key(49)]
    public int[] FavoriteRecordIds { get; set; }
    [Key(50)]
    public int ScheduleRepeatCount { get; set; }
    [Key(51)]
    public int RepeatScheduleUseNightShiftCash { get; set; }
    [Key(52)]
    public int IdolSkinId { get; set; }
    [Key(53)]
    public int[] OwnedInteractablePetIds { get; set; }
    [Key(54)]
    public MyHomeBuildingType[] OwnedPetPositions { get; set; }
    [Key(55)]
    public short OwnedPetRewardBits { get; set; }
    [Key(56)]
    public int[] NotOwnedInteractablePetIds { get; set; }
    [Key(57)]
    public MyHomeBuildingType[] NotOwnedPetPositions { get; set; }
}
