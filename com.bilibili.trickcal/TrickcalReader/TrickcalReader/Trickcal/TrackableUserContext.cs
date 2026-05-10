using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserContext {
    [Key(0)]
    public TrackableUserData User { get; set; }
    [Key(1)]
    public TrackablePocoDictionary<int, IUserItemData> Items { get; set; }
    [Key(2)]
    public TrackablePocoCompositeKeyDictionary<UserDeckKey, IUserDeckData> Decks { get; set; }
    [Key(3)]
    public TrackablePocoDictionary<int, IUserHeroData> Heroes { get; set; }
    [Key(4)]
    public TrackablePocoDictionary<int, IUserWorldQuestData> WorldQuests { get; set; }
    [Key(5)]
    public TrackablePocoDictionary<int, IUserWorldModeBasicData> WorldModeBasics { get; set; }
    [Key(6)]
    public TrackablePocoDictionary<int, IUserWorldTowerData> WorldTowers { get; set; }
    [Key(7)]
    public TrackablePocoDictionary<int, IUserMailData> Mails { get; set; }
    [Key(8)]
    public TrackablePocoDictionary<int, IUserStoryData> Stories { get; set; }
    [Key(9)]
    public TrackableUserMyHomeData MyHome { get; set; }
    [Key(10)]
    public TrackableUserMyHomeHousingData MyHomeHousing { get; set; }
    [Key(11)]
    public TrackablePocoDictionary<int, IUserMyHomeHousingPresetData> MyHomeHousingPreset { get; set; }
    [Key(12)]
    public TrackableUserFurnitureInventoryData FurnitureInventory { get; set; }
    [Key(13)]
    public TrackablePocoDictionary<int, IUserCardData> Cards { get; set; }
    [Key(14)]
    public TrackablePocoDictionary<int, IUserPetData> Pets { get; set; }
    [Key(15)]
    public TrackablePocoDictionary<int, IUserSoloRaidData> SoloRaids { get; set; }
    [Key(16)]
    public TrackablePocoCompositeKeyDictionary<UserSoloRaidStageKey, IUserSoloRaidStageData> SoloRaidStages { get; set; }
    [Key(17)]
    public TrackableUserShopData Shop { get; set; }
    [Key(18)]
    public TrackablePocoDictionary<int, IUserShopLimitData> ShopLimits { get; set; }
    [Key(19)]
    public TrackablePocoDictionary<int, IUserShopUnlockData> ShopUnlocks { get; set; }
    [Key(20)]
    public TrackablePocoDictionary<int, IUserGachaLimitData> GachaLimits { get; set; }
    [Key(21)]
    public TrackablePocoDictionary<int, IUserShopListData> ShopLists { get; set; }
    [Key(22)]
    public TrackableUserPvpArenaData PvpArena { get; set; }
    [Key(23)]
    public TrackablePocoDictionary<int, IUserQuestData> Quests { get; set; }
    [Key(24)]
    public TrackableUserTrickcalRankData TrickcalRank { get; set; }
    [Key(25)]
    public TrackablePocoDictionary<int, IUserTrickcalRankRewardBoxData> TrickcalRankRewardBox { get; set; }
    [Key(26)]
    public TrackablePocoDictionary<int, IUserTrickcalRankMatchRecordData> TrickcalRankMatchRecord { get; set; }
    [Key(27)]
    public TrackablePocoDictionary<int, IUserAlbumData> Albums { get; set; }
    [Key(28)]
    public TrackablePocoDictionary<int, IUserEventData> Events { get; set; }
    [Key(29)]
    public TrackableUserFriendContextData FriendContext { get; set; }
    [Key(30)]
    public TrackablePocoDictionary<int, IUserFriendData> Friends { get; set; }
    [Key(31)]
    public TrackablePocoDictionary<int, IUserFriendRequestData> FriendRequests { get; set; }
    [Key(32)]
    public TrackablePocoDictionary<GatherStatusType, IUserGatherHeroData> GatherHeroes { get; set; }
    [Key(33)]
    public TrackablePocoDictionary<int, IUserSetData> Sets { get; set; }
    [Key(34)]
    public TrackablePocoDictionary<int, IUserPassData> Pass { get; set; }
    [Key(35)]
    public TrackablePocoDictionary<int, IUserShopFlatData> ShopFlat { get; set; }
    [Key(36)]
    public TrackablePocoDictionary<int, IUserThemeEventData> ThemeEvent { get; set; }
    [Key(37)]
    public TrackablePocoDictionary<int, IUserRecordData> Records { get; set; }
    [Key(38)]
    public TrackablePocoDictionary<int, IUserMiniGameData> MiniGames { get; set; }
    [Key(39)]
    public TrackablePocoDictionary<int, IUserDropEventData> DropEvent { get; set; }
    [Key(40)]
    public TrackablePocoDictionary<int, IUserBingoEventData> BingoEvent { get; set; }
    [Key(41)]
    public TrackableUserGuildData Guild { get; set; }
    [Key(42)]
    public TrackablePocoDictionary<int, IUserSoloEndData> SoloEnd { get; set; }
    [Key(43)]
    public TrackablePocoCompositeKeyDictionary<UserSoloEndWorldKey, IUserSoloEndWorldData> SoloEndWorld { get; set; }
    [Key(44)]
    public TrackablePocoCompositeKeyDictionary<UserSoloEndStageKey, IUserSoloEndStageData> SoloEndStage { get; set; }
    [Key(45)]
    public TrackablePocoDictionary<int, IUserRerunData> Reruns { get; set; }
    [Key(46)]
    public TrackablePocoCompositeKeyDictionary<UserLobbyKey, IUserLobbyData> Lobby { get; set; }
    [Key(47)]
    public TrackablePocoCompositeKeyDictionary<UserPetDispatchTaskKey, IUserPetDispatchTaskData> PetDispatchTask { get; set; }
    [Key(48)]
    public TrackableUserPetDispatchData PetDispatch { get; set; }
    [Key(49)]
    public TrackablePocoDictionary<int, IUserWorldAsideData> WorldAsides { get; set; }
    [Key(50)]
    public TrackablePocoCompositeKeyDictionary<UserLotteryEventKey, IUserLotteryEventData> LotteryEvents { get; set; }
    [Key(51)]
    public TrackablePocoCompositeKeyDictionary<UserGlobalBattleEventKey, IUserGlobalBattleEventData> GlobalBattleEvent { get; set; }
    [Key(52)]
    public TrackablePocoCompositeKeyDictionary<UserGlobalBattleEventWorldKey, IUserGlobalBattleEventWorldData> GlobalBattleEventWorld { get; set; }
    [Key(53)]
    public TrackablePocoCompositeKeyDictionary<UserGlobalBattleEventBossKey, IUserGlobalBattleEventBossData> GlobalBattleEventBoss { get; set; }
    [Key(54)]
    public TrackablePocoCompositeKeyDictionary<UserMixedEventWorldKey, IUserMixedEventWorldData> MixedEventWorld { get; set; }
    [Key(55)]
    public TrackablePocoDictionary<int, IUserPointEventData> PointEvents { get; set; }
    [Key(56)]
    public TrackablePocoDictionary<int, IUserResourceOccupyEventData> ResourceOccupyEvents { get; set; }
    [Key(57)]
    public TrackablePocoCompositeKeyDictionary<UserAugmentChallengeKey, IUserAugmentChallengeData> AugmentChallenges { get; set; }
    [Key(58)]
    public TrackablePocoCompositeKeyDictionary<UserRecordEventKey, IUserRecordEventData> RecordEvents { get; set; }
    [Key(59)]
    public TrackablePocoDictionary<int, IUserDailyTimeEventData> DailyTimeEvents { get; set; }
    [Key(60)]
    public TrackablePocoDictionary<int, IUserNpcData> Npcs { get; set; }
    [Key(61)]
    public TrackablePocoCompositeKeyDictionary<UserMyHomeProductionKey, IUserMyHomeProductionData> MyHomeProductions { get; set; }
    [Key(62)]
    public TrackablePocoDictionary<int, IUserVotingEventData> VotingEvents { get; set; }
    [Key(63)]
    public TrackablePocoDictionary<int, IUserWorldTutorialData> WorldTutorials { get; set; }
    [Key(64)]
    public TrackablePocoDictionary<TriggerType, IUserTriggerData> Triggers { get; set; }
    [Key(65)]
    public TrackablePocoDictionary<int, IUserGlobalWorldTowerData> GlobalWorldTowers { get; set; }
    [Key(66)]
    public TrackablePocoCompositeKeyDictionary<UserRecallKey, IUserRecallLimitData> RecallLimits { get; set; }
    [Key(67)]
    public TrackablePocoDictionary<int, IUserMixedEventData> MixedEvents { get; set; }
    [Key(68)]
    public TrackablePocoCompositeKeyDictionary<UserCardDeckKey, IUserCardDeckData> CardDecks { get; set; }
    [Key(69)]
    public TrackablePocoDictionary<int, IUserEventHeroData> EventHeroes { get; set; }
    [Key(70)]
    public TrackablePocoCompositeKeyDictionary<UserUserSkillChallengeKey, IUserUserSkillChallengeData> UserSkillChallenges { get; set; }
    [Key(71)]
    public TrackablePocoCompositeKeyDictionary<UserHomeEventKey, IUserHomeEventData> HomeEvents { get; set; }
    [Key(72)]
    public TrackablePocoDictionary<int, IUserTileEventData> TileEvents { get; set; }
    [Key(73)]
    public TrackablePocoCompositeKeyDictionary<UserPointConsumeEventKey, IUserPointConsumeEventData> PointConsumeEvents { get; set; }
    [Key(74)]
    public TrackablePocoDictionary<int, IUserChaosArenaData> ChaosArena { get; set; }
    [Key(75)]
    public TrackablePocoCompositeKeyDictionary<UserHeroVoiceKey, IUserHeroVoiceData> HeroVoices { get; set; }
    [Key(76)]
    public TrackablePocoDictionary<int, ISideStoryData> SideStories { get; set; }
    [Key(77)]
    public TrackablePocoDictionary<int, IUserGachaponEventData> GachaponEvent { get; set; }
    [Key(78)]
    public TrackablePocoDictionary<int, IUserDailyLotteryEventData> DailyLotteryEvents { get; set; }
    [Key(79)]
    public TrackablePocoCompositeKeyDictionary<UserUserSkillKey, IUserUserSkillData> UserSkill { get; set; }
    [Key(80)]
    public TrackablePocoDictionary<int, IUserCookingTycoonData> CookingTycoon { get; set; }
    [Key(81)]
    public TrackablePocoDictionary<int, IUserSkinData> SkinData { get; set; }
    [Key(82)]
    public TrackablePocoCompositeKeyDictionary<UserAreaChallengeKey, IUserAreaChallengeData> AreaChallenges { get; set; }
    [Key(83)]
    public TrackablePocoDictionary<int, IUserAssembleEventData> AssembleEvents { get; set; }
    [Key(84)]
    public TrackableUserRechargeRebateData RechargeRebate { get; set; }
    [Key(85)]
    public TrackablePocoDictionary<int, IUserChainGiftData> ChainGifts { get; set; }
    [Key(86)]
    public TrackablePocoDictionary<int, IUserGachaRecordData> GachaRecords { get; set; }
    [Key(87)]
    public TrackablePocoDictionary<int, IUserWWEData> WWE { get; set; }
    [Key(88)]
    public TrackablePocoDictionary<int, IUserGachaSelectionData> GachaSelections { get; set; }
    [Key(89)]
    public TrackablePocoCompositeKeyDictionary<UserPuppetStoryKey, IUserPuppetStoryData> PuppetStories { get; set; }
    [Key(90)]
    public TrackablePocoDictionary<int, IUserDeductionEventData> DeductionEvents { get; set; }
    [Key(91)]
    public TrackablePocoDictionary<int, IUserTowerBattleData> TowerBattle { get; set; }
    [Key(92)]
    public TrackableUserGatherHeroInfoData GatherHeroInfo { get; set; }
    [Key(93)]
    public TrackablePocoDictionary<int, IUserWebLinkData> WebLink { get; set; }
    [Key(94)]
    public TrackablePocoCompositeKeyDictionary<UserChatEventEpisodeKey, IUserChatEventEpisodeData> ChatEvent { get; set; }
}
