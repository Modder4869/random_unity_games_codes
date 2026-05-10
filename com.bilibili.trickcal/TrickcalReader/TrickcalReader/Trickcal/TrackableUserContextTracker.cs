using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserContextTracker {
    [Key(0)]
    public TrackableContainerInnerTracker<TrackablePocoTracker<IUserData>, IUserData> SerializableUser { get; set; }
    [Key(1)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, IUserItemData>, TrackablePocoDictionary<int, IUserItemData>> SerializableItems { get; set; }
    [Key(2)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<UserDeckKey, IUserDeckData>, TrackablePocoCompositeKeyDictionary<UserDeckKey, IUserDeckData>> SerializableDecks { get; set; }
    [Key(3)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, IUserHeroData>, TrackablePocoDictionary<int, IUserHeroData>> SerializableHeroes { get; set; }
    [Key(4)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, IUserWorldQuestData>, TrackablePocoDictionary<int, IUserWorldQuestData>> SerializableWorldQuests { get; set; }
    [Key(5)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, IUserWorldModeBasicData>, TrackablePocoDictionary<int, IUserWorldModeBasicData>> SerializableWorldModeBasics { get; set; }
    [Key(6)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, IUserWorldTowerData>, TrackablePocoDictionary<int, IUserWorldTowerData>> SerializableWorldTowers { get; set; }
    [Key(7)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, IUserMailData>, TrackablePocoDictionary<int, IUserMailData>> SerializableMails { get; set; }
    [Key(8)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, IUserStoryData>, TrackablePocoDictionary<int, IUserStoryData>> SerializableStories { get; set; }
    [Key(9)]
    public TrackableContainerInnerTracker<TrackablePocoTracker<IUserMyHomeData>, IUserMyHomeData> SerializableMyHome { get; set; }
    [Key(10)]
    public TrackableContainerInnerTracker<TrackablePocoTracker<IUserMyHomeHousingData>, IUserMyHomeHousingData> SerializableMyHomeHousing { get; set; }
    [Key(11)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, IUserMyHomeHousingPresetData>, TrackablePocoDictionary<int, IUserMyHomeHousingPresetData>> SerializableMyHomeHousingPreset { get; set; }
    [Key(12)]
    public TrackableContainerInnerTracker<TrackablePocoTracker<IUserFurnitureInventoryData>, IUserFurnitureInventoryData> SerializableFurnitureInventory { get; set; }
    [Key(13)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, IUserCardData>, TrackablePocoDictionary<int, IUserCardData>> SerializableCards { get; set; }
    [Key(14)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, IUserPetData>, TrackablePocoDictionary<int, IUserPetData>> SerializablePets { get; set; }
    [Key(15)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, IUserSoloRaidData>, TrackablePocoDictionary<int, IUserSoloRaidData>> SerializableSoloRaids { get; set; }
    [Key(16)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<UserSoloRaidStageKey, IUserSoloRaidStageData>, TrackablePocoCompositeKeyDictionary<UserSoloRaidStageKey, IUserSoloRaidStageData>> SerializableSoloRaidStages { get; set; }
    [Key(17)]
    public TrackableContainerInnerTracker<TrackablePocoTracker<IUserShopData>, IUserShopData> SerializableShop { get; set; }
    [Key(18)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, IUserShopLimitData>, TrackablePocoDictionary<int, IUserShopLimitData>> SerializableShopLimits { get; set; }
    [Key(19)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, IUserShopUnlockData>, TrackablePocoDictionary<int, IUserShopUnlockData>> SerializableShopUnlocks { get; set; }
    [Key(20)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, IUserGachaLimitData>, TrackablePocoDictionary<int, IUserGachaLimitData>> SerializableGachaLimits { get; set; }
    [Key(21)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, IUserShopListData>, TrackablePocoDictionary<int, IUserShopListData>> SerializableShopLists { get; set; }
    [Key(22)]
    public TrackableContainerInnerTracker<TrackablePocoTracker<IUserPvpArenaData>, IUserPvpArenaData> SerializablePvpArena { get; set; }
    [Key(23)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, IUserQuestData>, TrackablePocoDictionary<int, IUserQuestData>> SerializableQuests { get; set; }
    [Key(24)]
    public TrackableContainerInnerTracker<TrackablePocoTracker<IUserTrickcalRankData>, IUserTrickcalRankData> SerializableTrickcalRank { get; set; }
    [Key(25)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, IUserTrickcalRankRewardBoxData>, TrackablePocoDictionary<int, IUserTrickcalRankRewardBoxData>> SerializableTrickcalRankRewardBox { get; set; }
    [Key(26)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, IUserTrickcalRankMatchRecordData>, TrackablePocoDictionary<int, IUserTrickcalRankMatchRecordData>> SerializableTrickcalRankMatchRecord { get; set; }
    [Key(27)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, IUserAlbumData>, TrackablePocoDictionary<int, IUserAlbumData>> SerializableAlbums { get; set; }
    [Key(28)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, IUserEventData>, TrackablePocoDictionary<int, IUserEventData>> SerializableEvents { get; set; }
    [Key(29)]
    public TrackableContainerInnerTracker<TrackablePocoTracker<IUserFriendContextData>, IUserFriendContextData> SerializableFriendContext { get; set; }
    [Key(30)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, IUserFriendData>, TrackablePocoDictionary<int, IUserFriendData>> SerializableFriends { get; set; }
    [Key(31)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, IUserFriendRequestData>, TrackablePocoDictionary<int, IUserFriendRequestData>> SerializableFriendRequests { get; set; }
    [Key(32)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<GatherStatusType, IUserGatherHeroData>, TrackablePocoDictionary<GatherStatusType, IUserGatherHeroData>> SerializableGatherHeroes { get; set; }
    [Key(33)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, IUserSetData>, TrackablePocoDictionary<int, IUserSetData>> SerializableSets { get; set; }
    [Key(34)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, IUserPassData>, TrackablePocoDictionary<int, IUserPassData>> SerializablePass { get; set; }
    [Key(35)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, IUserShopFlatData>, TrackablePocoDictionary<int, IUserShopFlatData>> SerializableShopFlat { get; set; }
    [Key(36)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, IUserThemeEventData>, TrackablePocoDictionary<int, IUserThemeEventData>> SerializableThemeEvent { get; set; }
    [Key(37)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, IUserRecordData>, TrackablePocoDictionary<int, IUserRecordData>> SerializableRecords { get; set; }
    [Key(38)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, IUserMiniGameData>, TrackablePocoDictionary<int, IUserMiniGameData>> SerializableMiniGames { get; set; }
    [Key(39)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, IUserDropEventData>, TrackablePocoDictionary<int, IUserDropEventData>> SerializableDropEvent { get; set; }
    [Key(40)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, IUserBingoEventData>, TrackablePocoDictionary<int, IUserBingoEventData>> SerializableBingoEvent { get; set; }
    [Key(41)]
    public TrackableContainerInnerTracker<TrackablePocoTracker<IUserGuildData>, IUserGuildData> SerializableGuild { get; set; }
    [Key(42)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, IUserSoloEndData>, TrackablePocoDictionary<int, IUserSoloEndData>> SerializableSoloEnd { get; set; }
    [Key(43)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<UserSoloEndWorldKey, IUserSoloEndWorldData>, TrackablePocoCompositeKeyDictionary<UserSoloEndWorldKey, IUserSoloEndWorldData>> SerializableSoloEndWorld { get; set; }
    [Key(44)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<UserSoloEndStageKey, IUserSoloEndStageData>, TrackablePocoCompositeKeyDictionary<UserSoloEndStageKey, IUserSoloEndStageData>> SerializableSoloEndStage { get; set; }
    [Key(45)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, IUserRerunData>, TrackablePocoDictionary<int, IUserRerunData>> SerializableReruns { get; set; }
    [Key(46)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<UserLobbyKey, IUserLobbyData>, TrackablePocoCompositeKeyDictionary<UserLobbyKey, IUserLobbyData>> SerializableLobby { get; set; }
    [Key(47)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<UserPetDispatchTaskKey, IUserPetDispatchTaskData>, TrackablePocoCompositeKeyDictionary<UserPetDispatchTaskKey, IUserPetDispatchTaskData>> SerializablePetDispatchTask { get; set; }
    [Key(48)]
    public TrackableContainerInnerTracker<TrackablePocoTracker<IUserPetDispatchData>, IUserPetDispatchData> SerializablePetDispatch { get; set; }
    [Key(49)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, IUserWorldAsideData>, TrackablePocoDictionary<int, IUserWorldAsideData>> SerializableWorldAsides { get; set; }
    [Key(50)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<UserLotteryEventKey, IUserLotteryEventData>, TrackablePocoCompositeKeyDictionary<UserLotteryEventKey, IUserLotteryEventData>> SerializableLotteryEvents { get; set; }
    [Key(51)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<UserGlobalBattleEventKey, IUserGlobalBattleEventData>, TrackablePocoCompositeKeyDictionary<UserGlobalBattleEventKey, IUserGlobalBattleEventData>> SerializableGlobalBattleEvent { get; set; }
    [Key(52)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<UserGlobalBattleEventWorldKey, IUserGlobalBattleEventWorldData>, TrackablePocoCompositeKeyDictionary<UserGlobalBattleEventWorldKey, IUserGlobalBattleEventWorldData>> SerializableGlobalBattleEventWorld { get; set; }
    [Key(53)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<UserGlobalBattleEventBossKey, IUserGlobalBattleEventBossData>, TrackablePocoCompositeKeyDictionary<UserGlobalBattleEventBossKey, IUserGlobalBattleEventBossData>> SerializableGlobalBattleEventBoss { get; set; }
    [Key(54)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<UserMixedEventWorldKey, IUserMixedEventWorldData>, TrackablePocoCompositeKeyDictionary<UserMixedEventWorldKey, IUserMixedEventWorldData>> SerializableMixedEventWorld { get; set; }
    [Key(55)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, IUserPointEventData>, TrackablePocoDictionary<int, IUserPointEventData>> SerializablePointEvents { get; set; }
    [Key(56)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, IUserResourceOccupyEventData>, TrackablePocoDictionary<int, IUserResourceOccupyEventData>> SerializableResourceOccupyEvents { get; set; }
    [Key(57)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<UserAugmentChallengeKey, IUserAugmentChallengeData>, TrackablePocoCompositeKeyDictionary<UserAugmentChallengeKey, IUserAugmentChallengeData>> SerializableAugmentChallenges { get; set; }
    [Key(58)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<UserRecordEventKey, IUserRecordEventData>, TrackablePocoCompositeKeyDictionary<UserRecordEventKey, IUserRecordEventData>> SerializableRecordEvents { get; set; }
    [Key(59)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, IUserDailyTimeEventData>, TrackablePocoDictionary<int, IUserDailyTimeEventData>> SerializableDailyTimeEvents { get; set; }
    [Key(60)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, IUserNpcData>, TrackablePocoDictionary<int, IUserNpcData>> SerializableNpcs { get; set; }
    [Key(61)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<UserMyHomeProductionKey, IUserMyHomeProductionData>, TrackablePocoCompositeKeyDictionary<UserMyHomeProductionKey, IUserMyHomeProductionData>> SerializableMyHomeProductions { get; set; }
    [Key(62)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, IUserVotingEventData>, TrackablePocoDictionary<int, IUserVotingEventData>> SerializableVotingEvents { get; set; }
    [Key(63)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, IUserWorldTutorialData>, TrackablePocoDictionary<int, IUserWorldTutorialData>> SerializableWorldTutorials { get; set; }
    [Key(64)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<TriggerType, IUserTriggerData>, TrackablePocoDictionary<TriggerType, IUserTriggerData>> SerializableTriggers { get; set; }
    [Key(65)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, IUserGlobalWorldTowerData>, TrackablePocoDictionary<int, IUserGlobalWorldTowerData>> SerializableGlobalWorldTowers { get; set; }
    [Key(66)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<UserRecallKey, IUserRecallLimitData>, TrackablePocoCompositeKeyDictionary<UserRecallKey, IUserRecallLimitData>> SerializableRecallLimits { get; set; }
    [Key(67)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, IUserMixedEventData>, TrackablePocoDictionary<int, IUserMixedEventData>> SerializableMixedEvents { get; set; }
    [Key(68)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<UserCardDeckKey, IUserCardDeckData>, TrackablePocoCompositeKeyDictionary<UserCardDeckKey, IUserCardDeckData>> SerializableCardDecks { get; set; }
    [Key(69)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, IUserEventHeroData>, TrackablePocoDictionary<int, IUserEventHeroData>> SerializableEventHeroes { get; set; }
    [Key(70)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<UserUserSkillChallengeKey, IUserUserSkillChallengeData>, TrackablePocoCompositeKeyDictionary<UserUserSkillChallengeKey, IUserUserSkillChallengeData>> SerializableUserSkillChallenges { get; set; }
    [Key(71)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<UserHomeEventKey, IUserHomeEventData>, TrackablePocoCompositeKeyDictionary<UserHomeEventKey, IUserHomeEventData>> SerializableHomeEvents { get; set; }
    [Key(72)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, IUserTileEventData>, TrackablePocoDictionary<int, IUserTileEventData>> SerializableTileEvents { get; set; }
    [Key(73)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<UserPointConsumeEventKey, IUserPointConsumeEventData>, TrackablePocoCompositeKeyDictionary<UserPointConsumeEventKey, IUserPointConsumeEventData>> SerializablePointConsumeEvents { get; set; }
    [Key(74)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, IUserChaosArenaData>, TrackablePocoDictionary<int, IUserChaosArenaData>> SerializableChaosArena { get; set; }
    [Key(75)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<UserHeroVoiceKey, IUserHeroVoiceData>, TrackablePocoCompositeKeyDictionary<UserHeroVoiceKey, IUserHeroVoiceData>> SerializableHeroVoices { get; set; }
    [Key(76)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, ISideStoryData>, TrackablePocoDictionary<int, ISideStoryData>> SerializableSideStories { get; set; }
    [Key(77)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, IUserGachaponEventData>, TrackablePocoDictionary<int, IUserGachaponEventData>> SerializableGachaponEvent { get; set; }
    [Key(78)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, IUserDailyLotteryEventData>, TrackablePocoDictionary<int, IUserDailyLotteryEventData>> SerializableDailyLotteryEvents { get; set; }
    [Key(79)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<UserUserSkillKey, IUserUserSkillData>, TrackablePocoCompositeKeyDictionary<UserUserSkillKey, IUserUserSkillData>> SerializableUserSkill { get; set; }
    [Key(80)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, IUserCookingTycoonData>, TrackablePocoDictionary<int, IUserCookingTycoonData>> SerializableCookingTycoon { get; set; }
    [Key(81)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, IUserSkinData>, TrackablePocoDictionary<int, IUserSkinData>> SerializableSkinData { get; set; }
    [Key(82)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<UserAreaChallengeKey, IUserAreaChallengeData>, TrackablePocoCompositeKeyDictionary<UserAreaChallengeKey, IUserAreaChallengeData>> SerializableAreaChallenges { get; set; }
    [Key(83)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, IUserAssembleEventData>, TrackablePocoDictionary<int, IUserAssembleEventData>> SerializableAssembleEvents { get; set; }
    [Key(84)]
    public TrackableContainerInnerTracker<TrackablePocoTracker<IUserRechargeRebateData>, IUserRechargeRebateData> SerializableRechargeRebate { get; set; }
    [Key(85)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, IUserChainGiftData>, TrackablePocoDictionary<int, IUserChainGiftData>> SerializableChainGifts { get; set; }
    [Key(86)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, IUserGachaRecordData>, TrackablePocoDictionary<int, IUserGachaRecordData>> SerializableGachaRecords { get; set; }
    [Key(87)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, IUserWWEData>, TrackablePocoDictionary<int, IUserWWEData>> SerializableWWE { get; set; }
    [Key(88)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, IUserGachaSelectionData>, TrackablePocoDictionary<int, IUserGachaSelectionData>> SerializableGachaSelections { get; set; }
    [Key(89)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<UserPuppetStoryKey, IUserPuppetStoryData>, TrackablePocoCompositeKeyDictionary<UserPuppetStoryKey, IUserPuppetStoryData>> SerializablePuppetStories { get; set; }
    [Key(90)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, IUserDeductionEventData>, TrackablePocoDictionary<int, IUserDeductionEventData>> SerializableDeductionEvents { get; set; }
    [Key(91)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, IUserTowerBattleData>, TrackablePocoDictionary<int, IUserTowerBattleData>> SerializableTowerBattle { get; set; }
    [Key(92)]
    public TrackableContainerInnerTracker<TrackablePocoTracker<IUserGatherHeroInfoData>, IUserGatherHeroInfoData> SerializableGatherHeroInfo { get; set; }
    [Key(93)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<int, IUserWebLinkData>, TrackablePocoDictionary<int, IUserWebLinkData>> SerializableWebLink { get; set; }
    [Key(94)]
    public TrackableContainerInnerTracker<TrackablePocoDictionaryTracker<UserChatEventEpisodeKey, IUserChatEventEpisodeData>, TrackablePocoCompositeKeyDictionary<UserChatEventEpisodeKey, IUserChatEventEpisodeData>> SerializableChatEvent { get; set; }
}
