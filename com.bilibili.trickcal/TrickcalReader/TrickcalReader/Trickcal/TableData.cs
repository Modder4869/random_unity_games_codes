using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TableData {
    [Key("AccountReturnEvent")]
    public Dictionary<int, AccountReturnEventData> AccountReturn { get; set; }
    [Key("AccountReturnQuest")]
    public Dictionary<int, AccountReturnQuestData> AccountReturnQuestDatas { get; set; }
    [Key("AchievementQuest")]
    public Dictionary<int, AchievementQuestData> AchievementQuest { get; set; }
    [Key("AchievementQuestGroup")]
    public Dictionary<int, List<AchievementQuestGroupData>> AchievementQuestGroupList { get; set; }
    [Key("AdjustToken")]
    public Dictionary<TokenEventType, Dictionary<int, AdjustTokenData>> AdjustTokens { get; set; }
    [Key("AffinityLevelUp")]
    public Dictionary<int, AffinityLevelUpData> AffinityLevelUp { get; set; }
    [Key("Airbridge")]
    public Dictionary<AirbridgeEventType, List<AirbridgeData>> AirBridgeData { get; set; }
    [Key("AlbumInfo")]
    public Dictionary<int, AlbumInfoData> AlbumInfo { get; set; }
    [Key("AlbumMainCategory")]
    public Dictionary<int, AlbumMainCategoryData> AlbumMainCategory { get; set; }
    [Key("AlbumRelateUnit")]
    public Dictionary<int, Dictionary<int, List<AlbumRelateUnitData>>> AlbumRelateUnitGroup { get; set; }
    [Key("AlbumStep")]
    public Dictionary<int, List<AlbumStepData>> AlbumStep { get; set; }
    [Key("AlbumStepUp")]
    public Dictionary<AlbumType, List<AlbumStepUp>> AlbumStepUp { get; set; }
    [Key("AlbumStoryUnitGroup")]
    public Dictionary<int, AlbumStoryUnitGroupData> AlbumStoryUnitGroup { get; set; }
    [Key("AlbumSubCategory")]
    public Dictionary<int, AlbumSubCategoryData> AlbumSubCategory { get; set; }
    [Key("AlbumTribe")]
    public Dictionary<int, Dictionary<int, AlbumTribeData>> AlbumTribe { get; set; }
    [Key("AlbumTribeSummary")]
    public Dictionary<AlbumType, Dictionary<TribeType, AlbumTribeSummaryData>> AlbumTribeSummary { get; set; }
    [Key("AlbumUnit")]
    public Dictionary<int, Dictionary<AlbumDataType, AlbumUnitData>> AlbumUnit { get; set; }
    [Key("AlbumUnlock")]
    public Dictionary<AlbumType, Dictionary<AlbumDataType, AlbumUnlockData>> AlbumUnlock { get; set; }
    [Key("AllianceAppearRuleInfoData")]
    public Dictionary<int, AllianceAppearRuleInfoData> AllianceAppearRuleInfoData { get; set; }
    [Key("AnniversaryPage")]
    public Dictionary<int, AnniversaryPageData> AnniversaryPages { get; set; }
    [Key("AnotherInfo")]
    public Dictionary<int, AnotherInfoData> AnotherInfos { get; set; }
    [Key("AnotherModeGroup")]
    public Dictionary<int, List<AnotherModeGroupData>> AnotherModeGroups { get; set; }
    [Key("ArcadeSeasonInfo")]
    public Dictionary<int, ArcadeSeasonData> ArcadeSeason { get; set; }
    [Key("ArcadeSeasonRankReward")]
    public Dictionary<int, ArcadeSeasonRankRewardData> ArcadeSeasonRankReward { get; set; }
    [Key("ArchiveLevelUp")]
    public Dictionary<int, ArchiveLevelUpData> ArchiveLevelUp { get; set; }
    [Key("AreaChallengeEvent")]
    public Dictionary<int, AreaChallengeEventData> AreaChallengeEvent { get; set; }
    [Key("AreaChallengeInfo")]
    public Dictionary<int, AreaChallengeInfoData> AreaChallengeInfos { get; set; }
    [Key("ArtifactLevel")]
    public Dictionary<int, List<ArtifactLevelData>> ArtifactLevel { get; set; }
    [Key("ArtifactSet")]
    public Dictionary<int, Dictionary<ArtifactTriggerType, ArtifactSetData>> ArtifactSet { get; set; }
    [Key("AsideDrawBonus")]
    public Dictionary<DrawCardType, List<AsideDrawRuleData>> AsideDrawBonus { get; set; }
    [Key("AsideDrawRate")]
    public Dictionary<int, AsideDrawRateData> AsideDrawRate { get; set; }
    [Key("AsideEffect")]
    public Dictionary<int, Dictionary<int, List<AsideEffectData>>> AsideEffect { get; set; }
    [Key("AsideGrade")]
    public Dictionary<int, AsideGradeData> AsideGrade { get; set; }
    [Key("AsideHeroGrows")]
    public Dictionary<int, List<AsideHeroGrowData>> AsideHeroGrows { get; set; }
    [Key("AsideInfo")]
    public Dictionary<int, AsideInfoData> AsideInfo { get; set; }
    [Key("AsideLevel")]
    public Dictionary<int, AsideLevelData> AsideLevel { get; set; }
    [Key("AsideLevelUp")]
    public Dictionary<int, AsideLevelUpData> AsideLevelUp { get; set; }
    [Key("AsideLevelUpList")]
    public List<AsideLevelUpData> AsideLevelUpList { get; set; }
    [Key("AsideStaminaRefill")]
    public Dictionary<int, ShopAsideStaminaRefillData> AsideStaminaRefill { get; set; }
    [Key("AsideStatInfo")]
    public Dictionary<int, Dictionary<int, List<AsideStatInfoData>>> AsideStatInfo { get; set; }
    [Key("AsideUpgrade")]
    public Dictionary<int, AsideUpgradeData> AsideUpgrade { get; set; }
    [Key("AsideWaveInfo")]
    public Dictionary<int, List<List<AsideWaveData>>> AsideWaveInfo { get; set; }
    [Key("AssembleEvent")]
    public Dictionary<int, AssembleEventData> AssembleEvent { get; set; }
    [Key("AssembleEventGroup")]
    public Dictionary<int, Dictionary<int, AssembleEventGroupData>> AssembleEventGroup { get; set; }
    [Key("AugmentChallengeDrop")]
    public Dictionary<int, AugmentChallengeDropData> AugmentChallengeDrop { get; set; }
    [Key("AugmentChallengeExp")]
    public Dictionary<int, AugmentChallengeExpData> AugmentChallengeExp { get; set; }
    [Key("AugmentChallengeInfo")]
    public Dictionary<int, AugmentChallengeInfoData> AugmentChallengeInfos { get; set; }
    [Key("AugmentChallengeLevel")]
    public Dictionary<int, AugmentChallengeLevelData> AugmentChallengeLevels { get; set; }
    [Key("AugmentChallengeRank")]
    public Dictionary<int, AugmentChallengeRankData> AugmentChallengeRank { get; set; }
    [Key("AugmentChallengeScorePer")]
    public Dictionary<int, AugmentChallengeScorePerData> AugmentChallengeScorePer { get; set; }
    [Key("AugmentInfo")]
    public Dictionary<int, AugmentInfoData> AugmentInfos { get; set; }
    [Key("AugmentLevel")]
    public Dictionary<int, AugmentLevelData> AugmentLevel { get; set; }
    [Key("AugmentSelect")]
    public Dictionary<int, AugmentSelectData> AugmentSelect { get; set; }
    [Key("AuthorityLevel")]
    public Dictionary<int, List<AuthorityLevelData>> AuthorityLevel { get; set; }
    [Key("AutoReceiveQuest")]
    public Dictionary<int, AutoReceiveQuestData> AutoReceiveQuest { get; set; }
    [Key("BalanceInfo")]
    public Dictionary<int, BalanceInfoData> BalanceInfo { get; set; }
    [Key("BalanceReward")]
    public Dictionary<int, Dictionary<int, MixedEventBalanceRewardData>> BalanceReward { get; set; }
    [Key("BalanceUnlockInfo")]
    public Dictionary<int, Dictionary<int, MixedEventBalanceUnlockData>> BalanceUnlock { get; set; }
    [Key("BannedWord")]
    public List<string> BannedWord { get; set; }
    [Key("BeginnerQuest")]
    public Dictionary<int, BeginnerQuestData> BeginnerQuest { get; set; }
    [Key("BingoEvent")]
    public Dictionary<int, BingoEventData> BingoEvent { get; set; }
    [Key("BingoInteractionGroup")]
    public Dictionary<int, BingoInteractionGroupData> BingoInteractionGroup { get; set; }
    [Key("BingoLineInfo")]
    public Dictionary<int, BingoLineInfoData> BingoLineInfo { get; set; }
    [Key("BingoOpenPattern")]
    public Dictionary<int, List<BingoOpenPatternData>> BingoOpenPattern { get; set; }
    [Key("BingoOpenPatternGroup")]
    public Dictionary<int, BingoOpenPatternGroupData> BingoOpenPatternGroup { get; set; }
    [Key("BingoRoundInfo")]
    public Dictionary<int, BingoRoundInfoData> BingoRoundInfo { get; set; }
    [Key("BingoTileInfo")]
    public Dictionary<int, BingoTileInfoData> BingoTileInfo { get; set; }
    [Key("BoardGateOpen")]
    public Dictionary<int, BoardGateOpenData> BoardGateOpen { get; set; }
    [Key("BoardInfo")]
    public Dictionary<int, BoardData> BoardInfo { get; set; }
    [Key("CallUnitClient")]
    public Dictionary<int, CallUnitData> CallUnitInfo { get; set; }
    [Key("CallUnitStageClient")]
    public Dictionary<(int, int), CallUnitData> CallUnitInfo_Stage { get; set; }
    [Key("CardInfo")]
    public Dictionary<int, CardInfoData> CardInfo { get; set; }
    [Key("CardLevel")]
    public Dictionary<int, CardLevelData> CardLevel { get; set; }
    [Key("CashShopData")]
    public Dictionary<int, CashShopData> CashShopData { get; set; }
    [Key("ChainTypeGiftMaster")]
    public Dictionary<int, BilibiliChainTypeGiftMasterData> ChainTypeGiftMaster { get; set; }
    [Key("ChainTypeMaster")]
    public Dictionary<int, Dictionary<int, BilibiliChainTypeMasterData>> ChainGiftType { get; set; }
    [Key("ChaosArenaAdditionRule")]
    public Dictionary<int, ChaosArenaAdditionRuleData> ChaosArenaAdditionRule { get; set; }
    [Key("ChaosArenaAllianceAppearData")]
    public Dictionary<int, ChaosArenaAllianceAppearData> ChaosArenaAllianceAppearData { get; set; }
    [Key("ChaosArenaAppearMonsterGroup")]
    public Dictionary<int, List<ChaosArenaAppearMonsterGroupData>> ChaosArenaAppearMonsterGroup { get; set; }
    [Key("ChaosArenaCard")]
    public Dictionary<int, Dictionary<int, ChaosArenaCardData>> ChaosArenaCard { get; set; }
    [Key("ChaosArenaInfo")]
    public Dictionary<int, ChaosArenaInfoData> ChaosArenaInfo { get; set; }
    [Key("ChaosArenaNormalRule")]
    public Dictionary<int, ChaosArenaNormalRuleData> ChaosArenaNormalRule { get; set; }
    [Key("ChaosArenaReward")]
    public Dictionary<int, ChaosArenaRewardData> ChaosArenaReward { get; set; }
    [Key("ChaosArenaRuleInfo")]
    public Dictionary<ChaosArenaRuleType, Dictionary<int, ChaosArenaRuleInfoData>> ChaosArenaRuleInfo { get; set; }
    [Key("ChaosArenaStatusBonus")]
    public Dictionary<int, ChaosArenaStatusBonusData> ChaosArenaStatusBonus { get; set; }
    [Key("ChaosArenaTestSetting")]
    public Dictionary<int, List<ChaosArenaTestSettingData>> ChaosArenaTestSetting { get; set; }
    [Key("ChaosArenaTestSpellSetting")]
    public Dictionary<int, List<ChaosArenaTestSpellSettingData>> ChaosArenaTestSpellSetting { get; set; }
    [Key("ChapterInfo")]
    public Dictionary<int, ChapterData> ChapterInfo { get; set; }
    [Key("ChatChapterInfo")]
    public Dictionary<int, ChatChapterInfo> ChatChapterInfo { get; set; }
    [Key("ChatDialogue")]
    public Dictionary<int, ChatDialogue> ChatDialogue { get; set; }
    [Key("ChatEpisodeInfo")]
    public Dictionary<int, ChatEpisodeInfo> ChatEpisodeInfo { get; set; }
    [Key("ChatEventDialogue")]
    public Dictionary<int, Dictionary<int, ChatEventDialogue>> ChatEventDialogue { get; set; }
    [Key("ChatEventUIInfo")]
    public Dictionary<int, ChatEventUIInfoData> ChatEventUIInfo { get; set; }
    [Key("ChoiceEvent")]
    public Dictionary<int, MixedEventChoiceEventData> MixedEventChoiceEvent { get; set; }
    [Key("CommentGroup")]
    public Dictionary<int, Dictionary<int, CommentGroupData>> CommentGroup { get; set; }
    [Key("ContentsInfo")]
    public Dictionary<ContentsType, ContentsData> ContentsInfo { get; set; }
    [Key("ContentsLock")]
    public Dictionary<(int, MixedEventContentsType), MixedEventContentsLockData> MixedEventContentsLockList { get; set; }
    [Key("ContentsNotice")]
    public Dictionary<ContentsNoticeType, Dictionary<int, ContentsNoticeData>> ContentsNotice { get; set; }
    [Key("CookingTycoonAchievementGroup")]
    public Dictionary<int, List<CookingTycoonAchievementGroupData>> CookingTycoonAchievementGroup { get; set; }
    [Key("CookingTycoonContents")]
    public Dictionary<int, CookingTycoonContentsData> CookingTycoonContents { get; set; }
    [Key("CookingTycoonContentsConfig")]
    public Dictionary<(int, CookingTycoonContentsType), CookingTycoonContentsConfigData> CookingTycoonContentsConfigs { get; set; }
    [Key("CookingTycoonContentsInfo")]
    public Dictionary<int, CookingTycoonContentsInfoData> CookingTycoonContentsInfo { get; set; }
    [Key("CookingTycoonCuisine")]
    public Dictionary<int, CookingTycoonCuisineData> CookingTycoonCuisine { get; set; }
    [Key("CookingTycoonDetailPlay")]
    public Dictionary<int, CookingTycoonDetailPlayData> CookingTycoonDetailPlayInfos { get; set; }
    [Key("CookingTycoonEvaluation")]
    public Dictionary<int, CookingTycoonEvaluationData> CookingTycoonEvaluation { get; set; }
    [Key("CookingTycoonIngredient")]
    public Dictionary<int, CookingTycoonIngredientData> CookingTycoonIngredient { get; set; }
    [Key("CookingTycoonInteraction")]
    public Dictionary<int, CookingTycoonInteractionData> CookingTycoonInteractions { get; set; }
    [Key("CookingTycoonOrder")]
    public Dictionary<int, CookingTycoonOrderData> CookingTycoonOrder { get; set; }
    [Key("CookingTycoonOrderStanding")]
    public Dictionary<int, CookingTycoonOrderStandingData> CookingTycoonOrderStandings { get; set; }
    [Key("CookingTycoonQuest")]
    public Dictionary<int, CookingTycoonQuestData> CookingTycoonQuest { get; set; }
    [Key("CookingTycoonQueue")]
    public Dictionary<int, CookingTycoonQueueData> CookingTycoonQueue { get; set; }
    [Key("CookingTycoonRankReward")]
    public Dictionary<int, CookingTycoonRankRewardData> CookingTycoonRankReward { get; set; }
    [Key("CookingTycoonResult")]
    public Dictionary<int, List<CookingTycoonResultData>> CookingTycoonResultInfo { get; set; }
    [Key("CookingTycoonSeasonInfo")]
    public Dictionary<int, CookingTycoonSeasonInfoData> CookingTycoonSeasonInfo { get; set; }
    [Key("CookingTycoonStageInfo")]
    public Dictionary<int, CookingTycoonStageInfoData> CookingTycoonStageInfo { get; set; }
    [Key("CookingTycoonToastMessage")]
    public Dictionary<int, CookingTycoonToastMessageData> CookingTycoonToastMessages { get; set; }
    [Key("CustomDropGroups")]
    public Dictionary<CustomDropGroupKey, DropGroupData> CustomDropGroups { get; set; }
    [Key("DailyEvent")]
    public Dictionary<int, DailyEventData> DailyEvent { get; set; }
    [Key("DailyLotteryEventGroup")]
    public Dictionary<int, List<DailyLotteryEventGroup>> DailyLotteryEventGroup { get; set; }
    [Key("DailyLotteryEventRewardGroup")]
    public Dictionary<int, List<DailyLotteryEventRewardGroup>> DailyLotteryEventRewardGroupByGroupId { get; set; }
    [Key("DailyQuest")]
    public Dictionary<int, DailyQuestData> DailyQuest { get; set; }
    [Key("DailyRewards")]
    public Dictionary<int, Dictionary<int, DailyRewardsData>> DailyRewards { get; set; }
    [Key("DailyTimeEvent")]
    public Dictionary<int, Dictionary<int, DailyTimeEventData>> DailyTimeEvent { get; set; }
    [Key("DayLimit")]
    public Dictionary<int, List<DayLimitData>> DayLimitDatas { get; set; }
    [Key("DayLimitQuest")]
    public Dictionary<int, DayLimitQuestData> DayLimitQuestDatas { get; set; }
    [Key("DeductionEvent")]
    public Dictionary<int, Dictionary<int, DeductionEventData>> DeductionEvent { get; set; }
    [Key("DeductionEventMinimi")]
    public Dictionary<int, Dictionary<int, List<DeductionEventMinimiData>>> DeductionEventMinimi { get; set; }
    [Key("DeductionEventTeam")]
    public Dictionary<int, Dictionary<int, Dictionary<DeductionEventTeamType, DeductionEventTeamData>>> DeductionEventTeam { get; set; }
    [Key("DefaultItem")]
    public Dictionary<int, List<DefaultItemData>> DefaultItem { get; set; }
    [Key("DefaultText")]
    public Dictionary<(LanguageType, string), string> DefaultText { get; set; }
    [Key("Dialogue")]
    public Dictionary<int, Dictionary<int, Dictionary<int, DialogueData>>> Dialogue { get; set; }
    [Key("DialogueBase")]
    public Dictionary<int, Dictionary<int, DialogueBaseData>> DialogueBase { get; set; }
    [Key("DialogueBubble")]
    public Dictionary<int, DialogueBubbleData> DialogueBubble { get; set; }
    [Key("DialogueCharacter")]
    public Dictionary<int, Dictionary<int, Dictionary<int, DialogueCharacterData>>> DialogueCharacter { get; set; }
    [Key("DialogueCharacterMove")]
    public Dictionary<string, List<DialogueCharacterMoveData>> DialogueCharacterMove { get; set; }
    [Key("DialogueEffect")]
    public Dictionary<int, DialogueEffectData> DialogueEffect { get; set; }
    [Key("DialogueEmoticon")]
    public Dictionary<int, DialogueEmoticonData> DialogueEmoticon { get; set; }
    [Key("DialogueUnitAppear")]
    public Dictionary<int, Dictionary<int, int>> DialogueUnitAppearCount { get; set; }
    [Key("DiscountEvent")]
    public Dictionary<int, DiscountEventData> DiscountEventData { get; set; }
    [Key("DrawCardList")]
    public Dictionary<int, DrawCardListData> DrawCardList { get; set; }
    [Key("DrawRate")]
    public Dictionary<int, DrawRateData> DrawRate { get; set; }
    [Key("DropEvent")]
    public Dictionary<int, DropEventData> DropEvent { get; set; }
    [Key("DropGroups")]
    public Dictionary<int, DropGroupData> DropGroups { get; set; }
    [Key("EasterEgg")]
    public Dictionary<int, EasterEggData> EasterEggs { get; set; }
    [Key("EnText")]
    public Dictionary<string, string> EnText { get; set; }
    [Key("EpisodeInfo")]
    public Dictionary<int, EpisodeData> EpisodeInfo { get; set; }
    [Key("Equip")]
    public Dictionary<int, EquipInfoData> Equip { get; set; }
    [Key("Event")]
    public Dictionary<int, EventData> Event { get; set; }
    [Key("EventAchievementGroup")]
    public Dictionary<int, List<EventAchievementGroupData>> EventAchievementGroupList { get; set; }
    [Key("EventBonusHero")]
    public List<EventBonusHeroData> EventBonusHero { get; set; }
    [Key("EventBonusHeroGroup")]
    public Dictionary<EventBonusHeroGroupKey, EventBonusHeroGroupData> EventBonusHeroGroup { get; set; }
    [Key("EventBridgePageUI")]
    public Dictionary<int, Dictionary<(int, BridgeContentType), EventBridgePageUIData>> EventBridgePageUI { get; set; }
    [Key("EventCardEditInfo")]
    public Dictionary<int, EventCardEditInfoData> EventCardEditInfo { get; set; }
    [Key("EventLobbyInteraction")]
    public Dictionary<int, MixedEventLobbyInteractionData> MixedEventLobbyInteraction { get; set; }
    [Key("EventLobbyReward")]
    public Dictionary<int, MixedEventLobbyRewardData> MixedEventLobbyReward { get; set; }
    [Key("EventLobbyStep")]
    public Dictionary<int, Dictionary<int, MixedEventLobbyStepData>> MixedEventLobbyStep { get; set; }
    [Key("EventMinimiGroup")]
    public Dictionary<int, EventMinimiGroupData> EventMinimiGroup { get; set; }
    [Key("EventQuest")]
    public Dictionary<int, EventQuestData> EventQuest { get; set; }
    [Key("EventQuestGroup")]
    public Dictionary<int, EventQuestGroupData> EventQuestGroup { get; set; }
    [Key("EventStageInfo")]
    public Dictionary<int, EventStageInfoData> EventStageInfo { get; set; }
    [Key("EventTrigger")]
    public Dictionary<int, EventTriggerData> EventTrigger { get; set; }
    [Key("EventUI")]
    public Dictionary<int, EventUIData> EventUI { get; set; }
    [Key("EventUIStanding")]
    public Dictionary<int, EventUIStandingData> EventUIStanding { get; set; }
    [Key("EventUnitGrade")]
    public Dictionary<int, List<EventUnitGradeData>> EventUnitGrade { get; set; }
    [Key("EventUnitGradeMap")]
    public Dictionary<int, Dictionary<int, EventUnitGradeData>> EventUnitGradeMap { get; set; }
    [Key("EventUnitGroup")]
    public Dictionary<int, Dictionary<int, EventUnitGroupData>> EventUnitGroupMap { get; set; }
    [Key("EventUnitLevelGroup")]
    public Dictionary<int, EventUnitLevelGroupData> EventUnitLevelGroup { get; set; }
    [Key("EventUnitSkill")]
    public Dictionary<int, List<EventUnitSkillData>> EventUnitSkill { get; set; }
    [Key("EventUnitSkillEnhances")]
    public Dictionary<int, Dictionary<int, EventUnitSkillData>> EventUnitSkillEnhances { get; set; }
    [Key("EventUnitStatLevel")]
    public Dictionary<int, List<EventUnitStatLevelData>> EventUnitStatLevel { get; set; }
    [Key("EvenUnitStatEnhances")]
    public Dictionary<int, Dictionary<int, EventUnitStatLevelData>> EvenUnitStatEnhances { get; set; }
    [Key("ExtraAppear")]
    public Dictionary<int, ExtraAppearData> ExtraAppear { get; set; }
    [Key("ExtraTutorialGroup")]
    public Dictionary<int, ExtraTutorialGroupData> ExtraTutorialGroup { get; set; }
    [Key("ExtraTutorialInfo")]
    public Dictionary<int, ExtraTutorialInfoData> ExtraTutorialInfo { get; set; }
    [Key("ExtraTutorialServerSaveData")]
    public Dictionary<TutorialSaveType, ExtraTutorialServerSaveData> ExtraTutorialServerSave { get; set; }
    [Key("FakeLoadingInfo")]
    public List<FakeLoadingData> FakeLoadingInfo { get; set; }
    [Key("FakeLobbyStyleInfo")]
    public Dictionary<int, FakeLobbyStyleData> FakeLobbyStyle { get; set; }
    [Key("FakeUiTitle")]
    public Dictionary<int, FakeUiTitleData> FakeUiTitle { get; set; }
    [Key("FirstBonusReset")]
    public Dictionary<int, ShopFirstBonusResetData> ShopFirstBonusReset { get; set; }
    [Key("FixBattleSetInfo")]
    public Dictionary<int, FixBattleSetInfoData> FixBattleSetInfo { get; set; }
    [Key("FixCardSetGroup")]
    public Dictionary<int, Dictionary<int, FixCardSetGroupData>> FixCardSetGroup { get; set; }
    [Key("FixHeroSetGroup")]
    public Dictionary<int, Dictionary<int, FixHeroSetGroupData>> FixHeroSetGroup { get; set; }
    [Key("FlatInfo")]
    public Dictionary<int, FlatInfoData> FlatInfo { get; set; }
    [Key("FoodInfo")]
    public Dictionary<int, FoodInfoData> FoodInfo { get; set; }
    [Key("FoodPreference")]
    public Dictionary<int, Dictionary<int, FoodPreferenceData>> HeroFoodPreference { get; set; }
    [Key("ForcedAuthorityCondition")]
    public Dictionary<int, Dictionary<int, ForcedAuthorityConditionData>> ForcedAuthorityCondition { get; set; }
    [Key("FormalInfo")]
    public Dictionary<int, FormalData> FormalInfo { get; set; }
    [Key("GachaCardPickUpInfo")]
    public Dictionary<int, GachaPickUpCardData> GachaCardPickUpInfo { get; set; }
    [Key("GachaDailyCardCost")]
    public Dictionary<int, GachaDailyCardCostData> GachaDailyCardCostInfo { get; set; }
    [Key("GachaEventExchange")]
    public Dictionary<int, Dictionary<int, GachaEventExchangeData>> GachaEventExchange { get; set; }
    [Key("GachaGet")]
    public Dictionary<GachaObtainType, Dictionary<int, Dictionary<int, GachaGetData>>> GachaGet { get; set; }
    [Key("GachaInfo")]
    public Dictionary<int, GachaData> GachaInfo { get; set; }
    [Key("GachaMenuInfo")]
    public Dictionary<int, GachaMenuData> GachaMenuInfo { get; set; }
    [Key("GachaPickUpInfo")]
    public Dictionary<int, GachaPickUpData> GachaPickUpInfo { get; set; }
    [Key("GachaponEvent")]
    public Dictionary<int, GachaponEventData> GachaponEvent { get; set; }
    [Key("GachaponEventCountReward")]
    public Dictionary<int, Dictionary<int, GachaponEventCountRewardData>> GachaponEventCountReward { get; set; }
    [Key("GachaResult")]
    public Dictionary<int, GachaResultData> GachaResult { get; set; }
    [Key("GachaSpecInfo")]
    public Dictionary<int, GachaSpecData> GachaSpecInfo { get; set; }
    [Key("GatherHero")]
    public Dictionary<int, GatherHeroData> GatherHero { get; set; }
    [Key("GatherHeroNum")]
    public Dictionary<int, GatherHeroNumData> GatherHeroNum { get; set; }
    [Key("GatherHeroStatusLevel")]
    public Dictionary<GatherStatusType, Dictionary<int, GatherHeroStatusLevelData>> GatherHeroStatusLevel { get; set; }
    [Key("GiftRewardMaster")]
    public Dictionary<int, List<BilibiliGiftRewardMasterData>> GiftRewardMaster { get; set; }
    [Key("GlobalBattleEvent")]
    public Dictionary<int, GlobalBattleEventData> GlobalBattleEvent { get; set; }
    [Key("GlobalBattleEventBossBuff")]
    public Dictionary<int, GlobalBattleEventBossBuff> GlobalBattleEventBossBuff { get; set; }
    [Key("GlobalBattleEventServerBoss")]
    public Dictionary<int, List<GlobalBattleEventServerBossData>> GlobalBattleEventServerBoss { get; set; }
    [Key("GlobalBattleEventWorld")]
    public List<GlobalBattleEventWorldData> GlobalBattleEventWorld { get; set; }
    [Key("GlobalCurrenciesAmountReference")]
    public Dictionary<int, GlobalCurrenciesData> GlobalCurrenciesAmountReference { get; set; }
    [Key("GlobalSkillActionData")]
    public Dictionary<string, GlobalSkillActionData> GlobalSkillActionData { get; set; }
    [Key("GlobalSkillHandlerData")]
    public Dictionary<string, GlobalSkillHandlerData> GlobalSkillHandlerData { get; set; }
    [Key("GlobalSkillLevelData")]
    public Dictionary<string, GlobalSkillLevelData> GlobalSkillLevelData { get; set; }
    [Key("GlobalSkillObjectData")]
    public Dictionary<string, GlobalSkillObjectData> GlobalSkillObjectData { get; set; }
    [Key("GlobalStatusEffectData")]
    public Dictionary<string, GlobalStatusEffectData> GlobalStatusEffectData { get; set; }
    [Key("GlobalWeight")]
    public Dictionary<string, GlobalWeightData> GlobalWeight { get; set; }
    [Key("GoodsPath")]
    public Dictionary<int, List<DropPathInfo>> GoodsPath { get; set; }
    [Key("Guarantee")]
    public Dictionary<int, GuaranteeData> Guarantee { get; set; }
    [Key("GuildBeginnerSupportRewardData")]
    public Dictionary<int, GuildBeginnerSupportRewardData> GuildBeginnerSupportRewardData { get; set; }
    [Key("GuildEmblemBackground")]
    public Dictionary<int, GuildEmblemBackgroundData> GuildEmblemBackground { get; set; }
    [Key("GuildEmblemIcon")]
    public Dictionary<int, GuildEmblemIconData> GuildEmblemIcon { get; set; }
    [Key("GuildPetInteraction")]
    public Dictionary<GuildLobbyZoneType, GuildPetInteractionData> GuildPetInteraction { get; set; }
    [Key("HallOfFameGroup")]
    public Dictionary<int, List<HallOfFameGroup>> HallOfFameGroup { get; set; }
    [Key("Help")]
    public Dictionary<int, HelpData> Help { get; set; }
    [Key("HelpCount")]
    public Dictionary<int, List<HelpCountData>> HelpCount { get; set; }
    [Key("HelpDetail")]
    public Dictionary<int, List<HelpDetailData>> HelpDetail { get; set; }
    [Key("HeroAffinity")]
    public Dictionary<int, Dictionary<int, HeroAffinityData>> HeroAffinity { get; set; }
    [Key("HeroAffinityReaction")]
    public Dictionary<int, List<HeroAffinityReactionData>> HeroAffinityReaction { get; set; }
    [Key("HeroCallUIData")]
    public Dictionary<int, HeroCallUIData> HeroCallUIData { get; set; }
    [Key("HeroEquipEnhances")]
    public Dictionary<int, List<HeroEquipEnhanceData>> HeroEquipEnhances { get; set; }
    [Key("HeroEquipPresets")]
    public Dictionary<int, List<HeroEquipPresetData>> HeroEquipPresets { get; set; }
    [Key("HeroEquipRecipe")]
    public Dictionary<int, HeroEquipRecipeData> HeroEquipRecipe { get; set; }
    [Key("HeroEquipSpends")]
    public Dictionary<int, List<HeroEquipSpendData>> HeroEquipSpends { get; set; }
    [Key("HeroGrades")]
    public Dictionary<int, List<HeroGradeData>> HeroGrades { get; set; }
    [Key("HeroGrowEventGroup")]
    public Dictionary<int, Dictionary<int, HeroGrowEventGroupData>> HeroGrowEventGroup { get; set; }
    [Key("HeroGrowEventQuest")]
    public Dictionary<int, HeroGrowEventQuestData> HeroGrowEventQuest { get; set; }
    [Key("HeroGrows")]
    public Dictionary<int, List<HeroGrowData>> HeroGrows { get; set; }
    [Key("HeroInfo")]
    public Dictionary<int, HeroInfoData> HeroInfo { get; set; }
    [Key("HeroLevels")]
    public Dictionary<int, List<HeroLevelData>> HeroLevels { get; set; }
    [Key("HeroLevelUp")]
    public Dictionary<int, HeroLevelUpData> HeroLevelUp { get; set; }
    [Key("HeroLevelUpList")]
    public List<HeroLevelUpData> HeroLevelUpList { get; set; }
    [Key("HeroLove")]
    public Dictionary<int, Dictionary<StatType, HeroLoveData>> HeroLove { get; set; }
    [Key("HeroMotionExperienceEvent")]
    public Dictionary<int, HeroMotionExperienceEventData> HeroMotionExperienceEvent { get; set; }
    [Key("HeroMotionExperienceInfo")]
    public Dictionary<int, HeroMotionExperienceInfoData> HeroMotionExperienceInfo { get; set; }
    [Key("HeroRank")]
    public Dictionary<int, List<HeroRankData>> HeroRank { get; set; }
    [Key("HeroReactionUnlockDatas")]
    public Dictionary<UnitStandingType, Dictionary<int, Dictionary<ReactionType, HeroReactionUnlockData>>> HeroReactionUnlockDatas { get; set; }
    [Key("HeroSkinInfo")]
    public Dictionary<int, SkinInfoData> SkinInfo { get; set; }
    [Key("HeroSkinItemInfo")]
    public Dictionary<int, SkinItemInfoData> SkinItem { get; set; }
    [Key("HeroUpgrade")]
    public Dictionary<int, HeroUpgradeData> HeroUpgrade { get; set; }
    [Key("HeroUpgradeList")]
    public List<short> HeroUpgradeList { get; set; }
    [Key("HeroVoice")]
    public Dictionary<int, HeroVoiceData> HeroVoice { get; set; }
    [Key("HighlightTitle")]
    public Dictionary<int, HighlightTitleData> HighlightTitleData { get; set; }
    [Key("HighPersonality")]
    public Dictionary<string, HighPersonalityData> HighPersonality { get; set; }
    [Key("HomeEventActionGroup")]
    public Dictionary<int, HomeEventActionGroupData> HomeEventActionGroup { get; set; }
    [Key("HomeEventGroup")]
    public Dictionary<int, HomeEventGroupData> HomeEventGroup { get; set; }
    [Key("HomeEventInfo")]
    public Dictionary<int, HomeEventInfoData> HomeEventInfo { get; set; }
    [Key("HouseReward")]
    public Dictionary<int, HouseRewardData> HouseReward { get; set; }
    [Key("Interaction")]
    public Dictionary<InteractionContentsType, Dictionary<int, List<InteractionData>>> Interaction { get; set; }
    [Key("ItemAddEffects")]
    public Dictionary<int, AddEffectData> ItemAddEffects { get; set; }
    [Key("ItemArtifact")]
    public Dictionary<int, ItemArtifactData> ItemArtifact { get; set; }
    [Key("ItemAuthority")]
    public Dictionary<int, ItemAuthorityData> ItemAuthority { get; set; }
    [Key("ItemBattle")]
    public Dictionary<int, ItemBattleData> ItemBattle { get; set; }
    [Key("ItemNavigation")]
    public Dictionary<ItemNavigationType, ItemNavigationData> ItemNavigations { get; set; }
    [Key("ItemSpell")]
    public Dictionary<int, ItemSpellData> ItemSpell { get; set; }
    [Key("ItemWWERecords")]
    public Dictionary<int, Dictionary<int, List<WWERecordData>>> ItemWWERecords { get; set; }
    [Key("ItemWWESpells")]
    public Dictionary<int, Dictionary<TeamType, List<WWESpellData>>> ItemWWESpells { get; set; }
    [Key("JoanneMiniGameEnding")]
    public Dictionary<int, JoanneMiniGameEndingData> JoanneMiniGameEndings { get; set; }
    [Key("JoanneMiniGameMode")]
    public Dictionary<int, JoanneMiniGameModeData> JoanneMiniGameModes { get; set; }
    [Key("JoanneMiniGameStageInfo")]
    public Dictionary<int, JoanneMiniGameStageInfoData> JoanneMiniGameStageInfo { get; set; }
    [Key("JoanneMiniGameUnit")]
    public List<JoanneUnitData> JoanneUnitData { get; set; }
    [Key("JoanneMiniGameUnitGroup")]
    public List<JoanneUnitGroupData> JoanneUnitGroupData { get; set; }
    [Key("JoanneMiniGameZoneInfo")]
    public List<JoanneZoneInfoData> JoanneZoneInfoData { get; set; }
    [Key("JpText")]
    public Dictionary<string, string> JpText { get; set; }
    [Key("KrText")]
    public Dictionary<string, string> KrText { get; set; }
    [Key("LabRecipeInfo")]
    public Dictionary<int, LabRecipeInfoData> LabRecipeInfo { get; set; }
    [Key("LabResearch")]
    public Dictionary<int, LabResearchData> LabResearch { get; set; }
    [Key("LayoutGroup")]
    public Dictionary<int, Dictionary<int, List<LayoutGroupData>>> LayoutGroup { get; set; }
    [Key("LayoutInfo")]
    public Dictionary<int, LayoutInfoData> LayoutInfo { get; set; }
    [Key("LayoutOrder")]
    public Dictionary<int, Dictionary<FurnitureCategoryType, LayoutOrderData>> LayoutOrderDatas { get; set; }
    [Key("LevelReward")]
    public Dictionary<int, LevelRewardData> LevelReward { get; set; }
    [Key("LifeCondition")]
    public Dictionary<int, LifeConditionData> LifeCondition { get; set; }
    [Key("LifeConditionDrop")]
    public Dictionary<int, LifeConditionDropData> LifeConditionDrop { get; set; }
    [Key("LifeConditionDropGroup")]
    public Dictionary<int, LifeConditionDropGroupData> LifeConditionDropGroup { get; set; }
    [Key("LifeHero")]
    public Dictionary<int, LifeHeroData> LifeHero { get; set; }
    [Key("LifeLevelUp")]
    public Dictionary<int, LifeLevelUpData> LifeLevelUp { get; set; }
    [Key("LifeRewardEvent")]
    public Dictionary<int, LifeRewardEventData> LifeRewardEvent { get; set; }
    [Key("LifeScheduleLevelUp")]
    public Dictionary<int, LifeScheduleLevelUpData> LifeScheduleLevelUp { get; set; }
    [Key("LifeSkill")]
    public Dictionary<int, LifeSkillData> LifeSkill { get; set; }
    [Key("LifeSkillBonus")]
    public Dictionary<int, LifeSkillBonusData> LifeSkillBonus { get; set; }
    [Key("LifeSkillGroup")]
    public Dictionary<int, LifeSkillGroupData> LifeSkillGroup { get; set; }
    [Key("LifeSkillValue")]
    public Dictionary<int, LifeSkillValueData> LifeSkillValue { get; set; }
    [Key("LifeTask")]
    public Dictionary<int, LifeTaskData> LifeTask { get; set; }
    [Key("LifeTaskGradeSelect")]
    public Dictionary<int, LifeTaskGradeSelect> LifeTaskGradeSelect { get; set; }
    [Key("LifeTaskTypeSelect")]
    public Dictionary<int, LifeTaskTypeSelect> LifeTaskTypeSelect { get; set; }
    [Key("ListReset")]
    public Dictionary<int, ShopListResetData> ListReset { get; set; }
    [Key("LobbyBattleBtn")]
    public Dictionary<int, LobbyBattleBtnData> LobbyBattleBtn { get; set; }
    [Key("LobbyEffect")]
    public Dictionary<int, LobbyEffectData> LobbyEffect { get; set; }
    [Key("LobbyInfo")]
    public Dictionary<int, LobbyInfoData> LobbyInfo { get; set; }
    [Key("LobbyStyle")]
    public Dictionary<int, LobbyStyleData> LobbyStyle { get; set; }
    [Key("Lottery")]
    public Dictionary<int, LotteryData> Lottery { get; set; }
    [Key("LotteryEventAchievementGroup")]
    public Dictionary<int, List<LotteryEventAchievementGroupData>> LotteryEventAchievementGroup { get; set; }
    [Key("LotteryEventQuest")]
    public Dictionary<int, LotteryEventQuestData> LotteryEventQuest { get; set; }
    [Key("LotteryInfo")]
    public Dictionary<int, LotteryInfoData> LotteryInfo { get; set; }
    [Key("LotteryMainGroup")]
    public Dictionary<int, LotteryMainGroupData> LotteryMainGroup { get; set; }
    [Key("LoveLetterItem")]
    public Dictionary<int, LoveLetterItemData> LoveLetterItem { get; set; }
    [Key("MainQuest")]
    public Dictionary<int, MainQuestData> MainQuest { get; set; }
    [Key("MainRecipeCategory")]
    public Dictionary<int, LabMainRecipeCategory> LabMainRecipeCategory { get; set; }
    [Key("Material")]
    public Dictionary<int, MaterialInfoData> Material { get; set; }
    [Key("MemoryPiece")]
    public Dictionary<int, Dictionary<int, Dictionary<int, MemoryPieceData>>> MemoryPieceInfo { get; set; }
    [Key("MiniEvent")]
    public Dictionary<int, MiniEventData> MiniEvent { get; set; }
    [Key("MiniEventAchievementGroup")]
    public Dictionary<int, List<MiniEventAchievementGroupData>> MiniEventAchievementGroupList { get; set; }
    [Key("MiniEventQuest")]
    public Dictionary<int, MiniEventQuestData> MiniEventQuest { get; set; }
    [Key("MiniGameAchievementGroup")]
    public Dictionary<int, List<MiniGameAchievementGroupData>> MiniGameAchievementGroupList { get; set; }
    [Key("MiniGameButterAccuracy")]
    public List<MiniGameButterAccuracyData> MiniGameButterAccuracy { get; set; }
    [Key("MiniGameButterBeatMap")]
    public Dictionary<int, Dictionary<ButterMiniGameDifficultyType, MiniGameButterBeatMapData>> MiniGameButterBeatMapGroup { get; set; }
    [Key("MiniGameDianaYesterBlackSpell")]
    public Dictionary<int, List<MiniGameDianaYesterBlackSpell>> MiniGameDianaYesterBlackSpell { get; set; }
    [Key("MiniGameDianaYesterBlockGroup")]
    public Dictionary<int, List<MiniGameDianaYesterBlockGroup>> MiniGameDianaYesterBlockGroup { get; set; }
    [Key("MiniGameDianaYesterBlockInfo")]
    public Dictionary<int, MiniGameDianaYesterBlockInfo> MiniGameDianaYesterBlockInfo { get; set; }
    [Key("MiniGameDianaYesterEnding")]
    public Dictionary<int, MiniGameDianaYesterEnding> MiniGameDianaYesterEnding { get; set; }
    [Key("MiniGameDianaYesterGimmickInfo")]
    public Dictionary<int, MiniGameDianaYesterGimmickInfo> MiniGameDianaYesterGimmickInfo { get; set; }
    [Key("MiniGameDianaYesterMode")]
    public Dictionary<int, MiniGameDianaYesterModeData> MiniGameDianaYesterMiniGameMode { get; set; }
    [Key("MiniGameDianaYesterNormalSet")]
    public Dictionary<int, Dictionary<(int, int), MiniGameDianaYesterNormalSetData>> MiniGameDianaYesterNormalSet { get; set; }
    [Key("MiniGameDianaYesterStartSet")]
    public Dictionary<int, List<MiniGameDianaYesterStartSetData>> MiniGameDianaYesterStartSet { get; set; }
    [Key("MiniGameDianaYesterWhiteSpell")]
    public Dictionary<int, MiniGameDianaYesterWhiteSpell> MiniGameDianaYesterWhiteSpell { get; set; }
    [Key("MiniGameEdAcademyInfo")]
    public Dictionary<int, List<MiniGameEdAcademyData>> MiniGameEdAcademyByMiniGame { get; set; }
    [Key("MiniGameEdActiveSkill")]
    public Dictionary<int, Dictionary<int, MiniGameEdActiveSkillData>> MiniGameEdActiveSkillByMiniGame { get; set; }
    [Key("MiniGameEdActiveSkillChangeCost")]
    public Dictionary<int, MiniGameEdActiveSkillChangeCostData> MiniGameEdActiveSkillChangeCost { get; set; }
    [Key("MiniGameEdMode")]
    public Dictionary<int, Dictionary<int, MiniGameEdModeData>> MiniGameEdMode { get; set; }
    [Key("MiniGameEdMonsterInfo")]
    public Dictionary<int, MiniGameEdMonsterData> MiniGameEdMonster { get; set; }
    [Key("MiniGameEdStageInfo")]
    public Dictionary<int, List<MiniGameEdStageData>> MiniGameEdWaveByStage { get; set; }
    [Key("MiniGameEdUnitGachaInfo")]
    public Dictionary<int, Dictionary<int, MiniGameEdUnitGachaData>> MiniGameEdUnitGachaByMiniGame { get; set; }
    [Key("MiniGameEdUnitGrade")]
    public Dictionary<int, Dictionary<int, MiniGameEdUnitGradeData>> MiniGameEdUnitGradeByMiniGame { get; set; }
    [Key("MiniGameEdUnitInfo")]
    public Dictionary<int, MiniGameEdUnitData> MiniGameEdUnit { get; set; }
    [Key("MiniGameEdUnitSkill")]
    public Dictionary<int, List<MiniGameEdUnitSkillData>> MiniGameEdUnitSkillByMiniGame { get; set; }
    [Key("MiniGameInfo")]
    public Dictionary<int, MiniGameInfoData> MiniGameInfo { get; set; }
    [Key("MiniGameLeetsStage")]
    public Dictionary<int, MiniGameLeetsStageData> MiniGameLeetsStage { get; set; }
    [Key("MiniGameLeetsWorld")]
    public Dictionary<int, MiniGameLeetsWorldData> MiniGameLeetsWorld { get; set; }
    [Key("MiniGameQuest")]
    public Dictionary<int, MiniGameQuestData> MiniGameQuest { get; set; }
    [Key("MinigameVelaEnding")]
    public Dictionary<int, MinigameVelaEndingData> MinigameVelaEnding { get; set; }
    [Key("MinigameVelaFever")]
    public Dictionary<int, MinigameVelaFeverData> MinigameVelaFever { get; set; }
    [Key("MinigameVelaMode")]
    public Dictionary<int, MinigameVelaModeData> MinigameVelaMode { get; set; }
    [Key("MinigameVelaSpeed")]
    public Dictionary<int, List<MinigameVelaSpeedData>> MinigameVelaSpeed { get; set; }
    [Key("MinigameVelaUnit")]
    public Dictionary<int, MinigameVelaUnitData> MinigameVelaUnit { get; set; }
    [Key("MinigameVelaUnitGroup")]
    public Dictionary<int, List<MinigameVelaUnitGroupData>> MinigameVelaUnitGroup { get; set; }
    [Key("MinionInfo")]
    public Dictionary<int, MinionInfoData> MinionInfo { get; set; }
    [Key("MinionLevels")]
    public Dictionary<int, MinionLevelData> MinionLevel { get; set; }
    [Key("MixedEvent")]
    public Dictionary<int, MixedEventData> MixedEvent { get; set; }
    [Key("MixedEventAuthorityBattleEvent")]
    public Dictionary<int, Dictionary<StageDifficultyType, List<MixedEventAuthorityBattleEventData>>> MixedEventAuthorityBattleEvent { get; set; }
    [Key("MixedEventChapterManagement")]
    public Dictionary<int, ChapterManagementData> MixedEventStoryChapterManagement { get; set; }
    [Key("MixedEventChatEvent")]
    public Dictionary<int, ChatInfo> ChatInfo { get; set; }
    [Key("MixedEventCinematicStageInfo")]
    public Dictionary<int, MixedEventCinematicStageInfoData> MixedEventCinematicStageInfo { get; set; }
    [Key("MixedEventCinematicUnit")]
    public Dictionary<int, CinematicUnitData> MixedEventCinematicUnit { get; set; }
    [Key("MixedEventCurrency")]
    public Dictionary<(int, MixedEventContentsType), MixedEventTopUiData> MixedEventTopUiList { get; set; }
    [Key("MixedEventLoadingUnitGroup")]
    public Dictionary<int, MixedEventLoadingUnitGroupData> MixedEventLoadingUnitGroup { get; set; }
    [Key("MixedEventMainLobby")]
    public Dictionary<int, MixedEventMainLobbyData> MixedEventMainLobbyInfo { get; set; }
    [Key("ModeInfo")]
    public Dictionary<ModeType, Dictionary<int, ModeInfoData>> ModeInfo { get; set; }
    [Key("ModeStaminaRefill")]
    public Dictionary<int, ShopModeStaminaRefillData> ModeStaminaRefill { get; set; }
    [Key("MonsterInfo")]
    public Dictionary<int, MonsterInfoData> MonsterInfo { get; set; }
    [Key("MonsterLevel")]
    public Dictionary<int, MonsterLevelData> MonsterLevel { get; set; }
    [Key("MonsterStatusBonus")]
    public Dictionary<int, MonsterStatusBonusData> MonsterStatusBonus { get; set; }
    [Key("MyHomeCollection")]
    public Dictionary<int, MyHomeCollectionData> MyHomeCollection { get; set; }
    [Key("MyHomeDonationLevelUp")]
    public Dictionary<int, MyHomeDonationLevelUpData> MyHomeDonationLevelUp { get; set; }
    [Key("MyHomeFurniture")]
    public Dictionary<int, MyHomeFurnitureData> MyHomeFurniture { get; set; }
    [Key("MyHomeIdolSkinInfo")]
    public Dictionary<int, MyHomeIdolSkinData> MyHomeIdolSkinInfo { get; set; }
    [Key("MyHomeLevelUp")]
    public Dictionary<int, MyHomeLevelUpData> MyHomeLevelUp { get; set; }
    [Key("NPCInfo")]
    public Dictionary<int, NPCInfoData> NPCInfo { get; set; }
    [Key("OverLevel")]
    public Dictionary<int, OverLevelData> OverLevel { get; set; }
    [Key("PassMissionLevel")]
    public Dictionary<int, PassMissionLevelData> PassMissionLevel { get; set; }
    [Key("PassPremium")]
    public Dictionary<int, PassPremiumData> PassPremium { get; set; }
    [Key("PassReward")]
    public Dictionary<int, Dictionary<int, PassRewardData>> PassRewards { get; set; }
    [Key("PetAni")]
    public Dictionary<int, List<PetAniData>> PetAni { get; set; }
    [Key("PetAttribute")]
    public Dictionary<int, PetAttributeData> PetAttribute { get; set; }
    [Key("PetAttributeRank")]
    public Dictionary<int, PetAttributeRankData> PetAttributeRank { get; set; }
    [Key("PetDispatchAttribute")]
    public Dictionary<int, PetDispatchAttributeRankData> PetDispatchAttribute { get; set; }
    [Key("PetDispatchLevelUp")]
    public Dictionary<int, PetDispatchLevelUpData> PetDispatchLevelUp { get; set; }
    [Key("PetDispatchReward")]
    public Dictionary<ValueTuple<int, int, int>, PetDispatchRewardData> PetDispatchReward { get; set; }
    [Key("PetDispatchSeason")]
    public Dictionary<int, PetDispatchSeasonData> PetDispatchSeason { get; set; }
    [Key("PetDispatchTask")]
    public Dictionary<int, PetDispatchTaskData> PetDispatchTask { get; set; }
    [Key("PetExp")]
    public Dictionary<int, PetExpData> PetExp { get; set; }
    [Key("PetInfo")]
    public Dictionary<int, PetInfoData> PetInfo { get; set; }
    [Key("PetItem")]
    public Dictionary<int, PetItemData> PetItem { get; set; }
    [Key("PetLevel")]
    public Dictionary<int, List<PetLevelData>> PetLevel { get; set; }
    [Key("PetReward")]
    public Dictionary<int, PetRewardData> PetReward { get; set; }
    [Key("PointConsumeEvent")]
    public Dictionary<int, Dictionary<int, Dictionary<int, PointConsumeEventData>>> PointConsumeEvent { get; set; }
    [Key("PointConsumeEventGroup")]
    public Dictionary<int, Dictionary<int, PointConsumeEventGroupData>> PointConsumeEventGroup { get; set; }
    [Key("PointEvent")]
    public Dictionary<int, Dictionary<int, PointEventData>> PointEvent { get; set; }
    [Key("PointEventGroup")]
    public Dictionary<int, Dictionary<int, PointEventGroupData>> PointEventGroup { get; set; }
    [Key("PopupResource")]
    public Dictionary<int, PopupResourceData> PopupResource { get; set; }
    [Key("PostGroup")]
    public Dictionary<int, Dictionary<int, PostGroupData>> PostGroup { get; set; }
    [Key("PreviewEvent")]
    public Dictionary<int, PreviewEventData> PreviewEvent { get; set; }
    [Key("PreviewEventGroup")]
    public Dictionary<int, PreviewEventGroupData> PreviewEventGroup { get; set; }
    [Key("ProductData")]
    public Dictionary<int, List<ShopProductData>> ProductData { get; set; }
    [Key("ProductionLabLevelUp")]
    public Dictionary<int, ProductionLabLevelUpData> ProductionLabLevelUp { get; set; }
    [Key("PuppetEffectData")]
    public Dictionary<int, List<PuppetEffectData>> PuppetEffectData { get; set; }
    [Key("PuppetEpisodeData")]
    public Dictionary<int, PuppetEpisodeData> PuppetEpisodeData { get; set; }
    [Key("PuppetSeasonData")]
    public Dictionary<int, PuppetSeasonData> PuppetSeasonData { get; set; }
    [Key("PuppetStepData")]
    public Dictionary<int, Dictionary<int, PuppetStepData>> PuppetStepData { get; set; }
    [Key("PvpBot")]
    public Dictionary<int, PvpBotData> PvpBot { get; set; }
    [Key("PvpBotBorderline")]
    public Dictionary<int, PvpBotBorderlineData> PvpBotBorderline { get; set; }
    [Key("PvpBotBorderMask")]
    public Dictionary<int, PvpBotBorderMaskData> PvpBotBorderMask { get; set; }
    [Key("PVPBotStatusBonus")]
    public Dictionary<int, PvpBotStatusBonus> PVPBotStatusBonus { get; set; }
    [Key("PvpBotUnit")]
    public Dictionary<int, PvpBotUnitData> PvpBotUnit { get; set; }
    [Key("PvpBoxReward")]
    public Dictionary<int, PvpBoxRewardData> PvpBoxReward { get; set; }
    [Key("PvpCardLimit")]
    public Dictionary<int, PvpCardLimitData> PvpCardLimit { get; set; }
    [Key("PvpGlobalBan")]
    public Dictionary<int, PvpGlobalBanData> PvpGlobalBan { get; set; }
    [Key("PvpNameModule")]
    public Dictionary<int, PvpNameModuleData> PvpNameModule { get; set; }
    [Key("PvpNameText")]
    public Dictionary<int, List<PvpNameTextData>> PvpNameText { get; set; }
    [Key("PVPNameTextMaster")]
    public Dictionary<int, List<PVPNameTextMasterData>> PVPNameTextMaster { get; set; }
    [Key("PvpReward")]
    public Dictionary<int, PvpRewardData> PvpReward { get; set; }
    [Key("PVPStatusBonus")]
    public Dictionary<int, PVPStatusBonusData> PVPStatusBonus { get; set; }
    [Key("PvpTestSetting")]
    public Dictionary<int, List<PvpTestSettingData>> PvpTestSetting { get; set; }
    [Key("QuestCategory")]
    public Dictionary<int, QuestCategoryData> QuestCategory { get; set; }
    [Key("QuestPointReward")]
    public Dictionary<int, Dictionary<int, QuestPointRewardData>> QuestPointRewards { get; set; }
    [Key("QuestSeason")]
    public Dictionary<int, QuestSeasonData> QuestSeason { get; set; }
    [Key("RaidSeasonRule")]
    public Dictionary<int, RaidSeasonRuleData> RaidSeasonRule { get; set; }
    [Key("RankGroup")]
    public Dictionary<ContentsType, List<RankGroupData>> RankGroup { get; set; }
    [Key("RanMiniGameBonus")]
    public Dictionary<int, RanMiniGameBonusData> RanMiniGameBonus { get; set; }
    [Key("RanMiniGameEnding")]
    public Dictionary<int, RanMiniGameEndingData> RanMiniGameEndings { get; set; }
    [Key("RanMiniGameFever")]
    public Dictionary<int, RanMiniGameFeverData> RanMiniGameFevers { get; set; }
    [Key("RanMiniGameMode")]
    public Dictionary<int, RanMiniGameModeData> RanMiniGameModes { get; set; }
    [Key("RanMiniGameScore")]
    public Dictionary<int, RanMiniGameScoreData> RanMiniGameScores { get; set; }
    [Key("RanMiniGameSkills")]
    public Dictionary<int, RanMiniGameSkillData> RanMiniGameSkills { get; set; }
    [Key("RecommendArtifact")]
    public Dictionary<int, ArtifactRecommend> RecommendArtifact { get; set; }
    [Key("RecordGroupGoods")]
    public Dictionary<int, RecordGroupGoodsData> RecordGroupGoods { get; set; }
    [Key("RecordReward")]
    public Dictionary<int, RecordRewardData> RecordReward { get; set; }
    [Key("RecordType")]
    public Dictionary<int, RecordTypeData> RecordType { get; set; }
    [Key("Rerun")]
    public Dictionary<int, RerunData> RerunDatas { get; set; }
    [Key("ResonanceResource")]
    public Dictionary<int, ResonanceResourceData> ResonanceResource { get; set; }
    [Key("ResourceOccupyEvent")]
    public Dictionary<int, List<ResourceOccupyEventData>> ResourceOccupyEvent { get; set; }
    [Key("RestaurantLevelUp")]
    public Dictionary<int, RestaurantLevelUpData> RestaurantLevelUp { get; set; }
    [Key("ScenarioTextEn")]
    public Dictionary<string, string> ScenarioTextEn { get; set; }
    [Key("ScenarioTextJp")]
    public Dictionary<string, string> ScenarioTextJp { get; set; }
    [Key("ScenarioTextKr")]
    public Dictionary<string, string> ScenarioTextKr { get; set; }
    [Key("ScenarioTextZh_chs")]
    public Dictionary<string, string> ScenarioTextZh_chs { get; set; }
    [Key("ScenarioTextZh_cht")]
    public Dictionary<string, string> ScenarioTextZh_cht { get; set; }
    [Key("ScoreEvent")]
    public Dictionary<int, List<ScoreEventData>> ScoreEvent { get; set; }
    [Key("ScoreEventReward")]
    public Dictionary<int, Dictionary<int, ScoreEventRewardData>> ScoreEventReward { get; set; }
    [Key("SeasonInfo")]
    public Dictionary<int, StorySeasonData> StorySeason { get; set; }
    [Key("SelectBattleEvent")]
    public Dictionary<int, SelectBattleEventData> SelectBattleEvent { get; set; }
    [Key("SelectBattleEventWorld")]
    public List<SelectBattleEventWorldData> SelectBattleEventWorld { get; set; }
    [Key("SelectBattleUserSkillWorldInfosByStage")]
    public Dictionary<int, SelectBattleUserSkillStageInfoData> SelectBattleUserSkillStageInfosByStage { get; set; }
    [Key("ServerEpisodeFoodAffinities")]
    public Dictionary<int, DialogueAffinityType[]> EpisodeFoodAffinities { get; set; }
    [Key("ServerHeroEpisodeFoodAffinities")]
    public Dictionary<int, HeroEpisodeFoodBranchAffinityData> HeroEpisodeFoodBranchAffinities { get; set; }
    [Key("SetInfo")]
    public Dictionary<int, SetInfoData> SetInfo { get; set; }
    [Key("SetReward")]
    public Dictionary<int, List<SetRewardData>> SetReward { get; set; }
    [Key("SFXIngame")]
    public Dictionary<int, Dictionary<SoundType, Dictionary<SkillType, List<SFXIngameData>>>> SFXIngame { get; set; }
    [Key("ShopData")]
    public Dictionary<int, ShopItemData> ShopData { get; set; }
    [Key("ShopEventGroup")]
    public Dictionary<int, ShopEventGroupData> ShopEventGroup { get; set; }
    [Key("ShopExchangeIDCard")]
    public Dictionary<int, ShopExchangeIDCardData> ShopExchangeIDCardData { get; set; }
    [Key("ShopFlatProduct")]
    public Dictionary<int, List<ShopFlatProductData>> ShopFlatProductData { get; set; }
    [Key("ShopMainCategory")]
    public Dictionary<int, ShopMainCategoryData> ShopMainCategory { get; set; }
    [Key("ShopPackageProductData")]
    public Dictionary<int, List<ShopPackageProductData>> ShopPackageProductData { get; set; }
    [Key("ShopRecommendFitEquipItem")]
    public Dictionary<(int, EquipType), ShopRecommendFitEquipItemData> ShopRecommendFitEquipItem { get; set; }
    [Key("ShopRecommendFitOtherItem")]
    public Dictionary<int, ShopRecommendFitOtherItemData> ShopRecommendFitOtherItem { get; set; }
    [Key("ShopRecommendGoodsFitOther")]
    public Dictionary<int, ShopRecommendGoodsFitOtherData> ShopRecommendGoodsFitOther { get; set; }
    [Key("ShopRecommendOtherProduct")]
    public Dictionary<ShopRecommendOtherType, ShopRecommendOtherProductData> ShopRecommendOtherProduct { get; set; }
    [Key("ShopRecommendProduct")]
    public Dictionary<ShopRecommendType, ShopRecommendProductData> ShopRecommendProduct { get; set; }
    [Key("ShopSubCategory")]
    public Dictionary<int, ShopSubCategoryData> ShopSubCategory { get; set; }
    [Key("SideStory")]
    public Dictionary<int, SideStoryData> SideStory { get; set; }
    [Key("SignatureCard")]
    public Dictionary<int, List<SignatureCardData>> SignatureCard { get; set; }
    [Key("SignatureSpellCard")]
    public Dictionary<int, Dictionary<int, List<SignatureSpellCardData>>> SignatureSpellCard { get; set; }
    [Key("SkillEffect_UnitUidKey")]
    public Dictionary<int, List<SkillEffectNewData>> SkillEffect_UnitUidKey { get; set; }
    [Key("SkillEffectNew")]
    public Dictionary<int, SkillEffectNewData> SkillEffectNew { get; set; }
    [Key("SkillEnhance")]
    public Dictionary<JobType, Dictionary<SkillType, List<SkillEnhanceData>>> SkillEnhances { get; set; }
    [Key("SkillInfo")]
    public Dictionary<int, List<SkillInfoData>> SkillInfo { get; set; }
    [Key("SkillInfoPVP")]
    public Dictionary<int, List<SkillInfoData>> SkillInfoPVP { get; set; }
    [Key("SkillLevel_EffectUids")]
    public Dictionary<int, List<int>> SkillLevel_EffectUids { get; set; }
    [Key("SkillLevel_Information")]
    public Dictionary<int, List<SkillLevelNewData>> SkillLevel_Information { get; set; }
    [Key("SkillLevelNew")]
    public Dictionary<ValueTuple<int, int, int>, List<SkillLevelNewData>> SkillLevelNew { get; set; }
    [Key("SkillLevelNew_Effect")]
    public Dictionary<int, List<int>> SkillLevelNew_EffectKey { get; set; }
    [Key("SkillLevelNewPVP")]
    public Dictionary<ValueTuple<int, int, int, int>, SkillLevelNewData> SkillLevelNewPVP { get; set; }
    [Key("SkillNew")]
    public Dictionary<int, List<SkillNewData>> SkillNew { get; set; }
    [Key("SkillNewPVP")]
    public Dictionary<(int, int), SkillNewData> SkillNewPVP { get; set; }
    [Key("SkinBGInfo")]
    public Dictionary<int, SkinBGInfoData> SkinBGInfo { get; set; }
    [Key("SkinDetail")]
    public Dictionary<int, SkinDetailData> SkinDetail { get; set; }
    [Key("SkinPassInfo")]
    public Dictionary<int, SkinPassInfoData> SkinPassInfo { get; set; }
    [Key("SkinPassMissionLevel")]
    public Dictionary<int, SkinPassMissionLevelData> SkinPassMissionLevel { get; set; }
    [Key("SkinPassReward")]
    public Dictionary<int, Dictionary<int, SkinPassRewardData>> SkinPassRewards { get; set; }
    [Key("SkinSetEvent")]
    public Dictionary<int, SkinSetEventData> SkinSetEvent { get; set; }
    [Key("SkinSpineUI")]
    public Dictionary<int, SkinSpineUIData> SkinSpineUI { get; set; }
    [Key("SlotContentGroup")]
    public Dictionary<int, List<SlotContentGroupData>> SlotContentsGroup { get; set; }
    [Key("SlotContents")]
    public Dictionary<int, SlotContentsData> SlotContents { get; set; }
    [Key("SlotContentsValue")]
    public Dictionary<int, SlotContentsValueData> SlotContentsValue { get; set; }
    [Key("SoloEndAchievementGroup")]
    public Dictionary<int, List<SoloEndAchievementGroupData>> SoloEndAchievementGroupList { get; set; }
    [Key("SoloEndAppear")]
    public Dictionary<SoloEndAppearType, Dictionary<int, SoloEndAppearData>> SoloEndAppear { get; set; }
    [Key("SoloEndAppearType")]
    public Dictionary<SoloEndAppearType, SoloEndAppearTypeData> SoloEndAppearType { get; set; }
    [Key("SoloEndAuthorityList")]
    public Dictionary<int, List<SoloEndAuthorityListData>> SoloEndAuthorityList { get; set; }
    [Key("SoloEndBossFury")]
    public Dictionary<int, SoloEndBossFuryData> SoloEndBossFury { get; set; }
    [Key("SoloEndCardLimit")]
    public Dictionary<CardType, Dictionary<int, SoloEndCardLimitData>> SoloEndCardLimit { get; set; }
    [Key("SoloEndContentsInfo")]
    public Dictionary<SoloEndTableKey, SoloEndContentsInfoData> SoloEndContentsInfo { get; set; }
    [Key("SoloEndMonsterLevel")]
    public Dictionary<ValueTuple<int, int, int>, SoloEndMonsterLevelData> SoloEndMonsterLevel { get; set; }
    [Key("SoloEndQuest")]
    public Dictionary<int, SoloEndQuestData> SoloEndQuest { get; set; }
    [Key("SoloEndRankReward")]
    public Dictionary<int, SoloEndRankRewardData> SoloEndRankReward { get; set; }
    [Key("SoloEndWorldList")]
    public Dictionary<int, List<SoloEndWorldListData>> SoloEndWorldList { get; set; }
    [Key("SoloRaidInfo")]
    public Dictionary<SoloRaidTableKey, SoloRaidInfoData> SoloRaidInfo { get; set; }
    [Key("SoloRaidReward")]
    public Dictionary<int, SoloRaidRewardData> SoloRaidReward { get; set; }
    [Key("SoundList")]
    public Dictionary<string, SoundResourceData> SoundList { get; set; }
    [Key("SoundSkillHit")]
    public Dictionary<string, string> SoundSkillHit { get; set; }
    [Key("SpellLevel")]
    public Dictionary<int, List<SpellLevelData>> SpellLevel { get; set; }
    [Key("StageDrawList")]
    public Dictionary<int, Dictionary<CardType, List<StageDrawListData>>> StageDrawList { get; set; }
    [Key("StageEffect")]
    public Dictionary<int, StageEffectData> StageEffect { get; set; }
    [Key("StageInfo")]
    public Dictionary<int, StageInfoData> StageInfo { get; set; }
    [Key("StageMission")]
    public Dictionary<int, StageMissionData> StageMission { get; set; }
    [Key("StaminaReFill")]
    public Dictionary<int, ShopStaminaRefillData> StaminaReFill { get; set; }
    [Key("StartSlotPick")]
    public Dictionary<int, StartSlotPickData> StartSlotPick { get; set; }
    [Key("StatusEffect")]
    public Dictionary<StatusEffect, StatusEffectData> StatusEffect { get; set; }
    [Key("StatusEffectDataNewData")]
    public Dictionary<string, StatusEffectDataNew> NewStatusEffectDatas { get; set; }
    [Key("StatusEffectSubTypeData")]
    public Dictionary<string, StatusEffectSubTypeData> StatusEffectSubTypeDatas { get; set; }
    [Key("StatusEffectUId")]
    public Dictionary<int, StatusEffectData> StatusEffectUId { get; set; }
    [Key("StoryFixBattle")]
    public Dictionary<int, StoryFixBattleData> StoryFixBattle { get; set; }
    [Key("StoryInfo")]
    public Dictionary<int, StoryData> StoryInfo { get; set; }
    [Key("SubRecipeCategory")]
    public Dictionary<int, LabSubRecipeCategoryData> LabSubRecipeCategory { get; set; }
    [Key("SubTypeTextInfo")]
    public Dictionary<string, SubTypeTextInfoData> StatusEffectSubTypeTextInfoDatas { get; set; }
    [Key("SummonLevel")]
    public Dictionary<int, SummonLevelData> SummonLevel { get; set; }
    [Key("SummonsCard")]
    public Dictionary<int, SummonsCardData> SummonsCard { get; set; }
    [Key("SynergyInfo")]
    public Dictionary<int, SynergyInfoData> SynergyInfo { get; set; }
    [Key("SynergyLevel")]
    public Dictionary<int, List<SynergyLevelData>> SynergyLevel { get; set; }
    [Key("TableDataKeys")]
    public Dictionary<int, CommunityMasterData> CommunityMaster { get; set; }
    [Key("TagResource")]
    public Dictionary<int, TagResourceData> TagResource { get; set; }
    [Key("TermsOfService")]
    public Dictionary<int, TermsOfServiceData> TermsOfService { get; set; }
    [Key("TestExBoardGroup")]
    public HashSet<ValueTuple<int, int, OutGameStatType>> TestExBoardGroup { get; set; }
    [Key("TestHeroSetGroup")]
    public Dictionary<int, List<TestHeroSetGroupData>> TestHeroSetGroup { get; set; }
    [Key("TestSetting")]
    public Dictionary<int, TestSettingData> TestSetting { get; set; }
    [Key("Theme17EasterEgg)")]
    public Dictionary<int, Theme17EasterEggData> Theme17EasterEgg { get; set; }
    [Key("Theme17Mode)")]
    public Dictionary<int, Theme17ModeData> Theme17Mode { get; set; }
    [Key("Theme17Score)")]
    public Dictionary<int, Theme17Score> Theme17Score { get; set; }
    [Key("Theme17Stage)")]
    public Dictionary<int, Theme17StageData> Theme17Stage { get; set; }
    [Key("Theme17UnitInfo)")]
    public Dictionary<int, Theme17UnitInfoData> Theme17UnitInfo { get; set; }
    [Key("Theme4End)")]
    public List<Theme4EndData> Theme4End { get; set; }
    [Key("Theme4Patient)")]
    public Dictionary<int, Theme4PatientData> Theme4Patient { get; set; }
    [Key("Theme4Stage)")]
    public Dictionary<int, Theme4StageData> Theme4Stage { get; set; }
    [Key("ThemeEvent")]
    public Dictionary<int, ThemeEventData> ThemeEvent { get; set; }
    [Key("ThemeEventAchievementGroup")]
    public Dictionary<int, List<ThemeEventAchievementGroupData>> ThemeEventAchievementGroupList { get; set; }
    [Key("ThemeEventBonusHero")]
    public Dictionary<int, Dictionary<int, ThemeEventBonusHeroData>> ThemeEventBonusHero { get; set; }
    [Key("ThemeEventQuest")]
    public Dictionary<int, ThemeEventQuestData> ThemeEventQuest { get; set; }
    [Key("ThemePass")]
    public Dictionary<int, ThemePassData> ThemePass { get; set; }
    [Key("ThemePassMissionLevel")]
    public Dictionary<int, ThemePassMissionLevelData> ThemePassMissionLevel { get; set; }
    [Key("ThemePassReward")]
    public Dictionary<int, Dictionary<int, ThemePassRewardData>> ThemePassReward { get; set; }
    [Key("TierSet")]
    public Dictionary<TierGrade, TierSetData> TierSet { get; set; }
    [Key("TileEventInfos")]
    public Dictionary<int, TileEventInfo> TileEventInfos { get; set; }
    [Key("TileEventTileInfos")]
    public Dictionary<int, TileEventTileInfo> TileEventTileInfos { get; set; }
    [Key("TournamentEventEntry")]
    public Dictionary<int, TournamentEventEntryData> TournamentEventEntry { get; set; }
    [Key("TournamentEventInfo")]
    public Dictionary<int, TournamentEventInfoData> TournamentEventInfo { get; set; }
    [Key("TournamentEventStep")]
    public Dictionary<int, List<TournamentEventStepData>> TournamentEventStep { get; set; }
    [Key("TowerBattleAchievementGroup")]
    public Dictionary<int, List<TowerBattleAchievementGroupData>> TowerBattleAchievementGroup { get; set; }
    [Key("TowerBattleEmotion")]
    public Dictionary<int, TowerBattleEmotionData> TowerBattleEmotion { get; set; }
    [Key("TowerBattleInfo")]
    public Dictionary<int, TowerBattleInfoData> TowerBattleInfo { get; set; }
    [Key("TowerBattleObjectGroup")]
    public Dictionary<int, List<TowerBattleObjectGroupData>> TowerBattleObjectGroup { get; set; }
    [Key("TowerBattleObjectInfo")]
    public Dictionary<int, TowerBattleObjectInfoData> TowerBattleObjectInfo { get; set; }
    [Key("TowerBattleQuest")]
    public Dictionary<int, TowerBattleQuestData> TowerBattleQuest { get; set; }
    [Key("TrainingRoomInfo")]
    public Dictionary<int, TrainingRoomInfo> TrainingRoomInfo { get; set; }
    [Key("TreasureBox")]
    public Dictionary<int, TreasureBoxData> TreasureBox { get; set; }
    [Key("TribeInfo")]
    public Dictionary<TribeType, TribeInfoData> TribeInfo { get; set; }
    [Key("TriggerPopupData")]
    public Dictionary<int, TriggerPopupData> TriggerPopupData { get; set; }
    [Key("Tutorial")]
    public Dictionary<int, TutorialData> Tutorial { get; set; }
    [Key("TutorialStageSetting")]
    public Dictionary<int, TutorialStageSettingData> TutorialStageSetting { get; set; }
    [Key("TutorialVideoCondition")]
    public Dictionary<int, TutorialVideoConditionData> TutorialVideoConditions { get; set; }
    [Key("UIGlobal")]
    public Dictionary<string, UiGlobalData> UIGlobal { get; set; }
    [Key("UiHeroStandingSpine")]
    public Dictionary<int, UiHeroStandingSpineData> UiHeroStandingSpine { get; set; }
    [Key("UiIngameSpine")]
    public Dictionary<int, UiIngameSpineData> UiIngameSpine { get; set; }
    [Key("UiMonsterSpine")]
    public Dictionary<int, UiMonsterSpineData> UiMonsterSpine { get; set; }
    [Key("UINPCCloset")]
    public Dictionary<int, UINPCClosetData> UiNpcCloset { get; set; }
    [Key("UiNPCStandingSpine")]
    public Dictionary<int, UiNpcStandingSpineData> UiNPCStandingSpine { get; set; }
    [Key("UiTitle")]
    public Dictionary<int, UiTitleData> UiTitle { get; set; }
    [Key("UiUserProfilePresent")]
    public Dictionary<int, UiUserProfilePresentData> UiUserProfilePresent { get; set; }
    [Key("UserBorderlineFilter")]
    public Dictionary<int, UserBorderlineFilterData> UserBorderlineFilter { get; set; }
    [Key("UserBorderlineInfo")]
    public Dictionary<int, UserBorderlineInfoData> UserBorderlineInfo { get; set; }
    [Key("UserEventBroadcasting")]
    public Dictionary<int, UserEventBroadcastingData> UserEventBroadcasting { get; set; }
    [Key("UserLevelUpInfo")]
    public Dictionary<int, UserLevelUpData> UserLevelUpInfo { get; set; }
    [Key("UserLevelUpInfoList")]
    public List<UserLevelUpData> UserLevelUpInfoList { get; set; }
    [Key("UserLvPassGroup")]
    public Dictionary<int, UserLvPassGroupData> UserLvPassGroup { get; set; }
    [Key("UserLvPassReward")]
    public Dictionary<int, Dictionary<int, UserLvPassRewardData>> UserLvPassReward { get; set; }
    [Key("UserNamePlateFilter")]
    public Dictionary<int, UserNamePlateFilterData> UserNamePlateFilter { get; set; }
    [Key("UserNamePlateInfo")]
    public Dictionary<int, UserNamePlateInfoData> UserNamePlateInfo { get; set; }
    [Key("UserNameStyleInfo")]
    public Dictionary<int, UserNameStyleData> UserNameStyleInfo { get; set; }
    [Key("UserProfileInfo")]
    public Dictionary<int, UserProfileInfoData> UserProfileInfo { get; set; }
    [Key("UserProfilePresent")]
    public Dictionary<int, UserProfilePresentData> UserProfilePresent { get; set; }
    [Key("UserSkillBattleRule")]
    public Dictionary<int, UserSkillBattleRuleData> UserSkillBattleRule { get; set; }
    [Key("UserSkillBuffInfo")]
    public Dictionary<UserSkillGrowthType, UserSkillBuffInfoData> UserSkillBuffInfo { get; set; }
    [Key("UserSkillChallengeInfos")]
    public Dictionary<int, UserSkillChallengeInfoData> UserSkillChallengeInfos { get; set; }
    [Key("UserSkillChallengeRank")]
    public Dictionary<int, UserSkillChallengeRankData> UserSkillChallengeRank { get; set; }
    [Key("UserSkillChallengeScorePer")]
    public Dictionary<MonsterType, UserSkillChallengeScorePerData> UserSkillChallengeScorePer { get; set; }
    [Key("UserSkillGimmickInfoData")]
    public Dictionary<int, UserSkillGimmickInfoData> UserSkillGimmickInfos { get; set; }
    [Key("UserSkillGrowthInfo")]
    public Dictionary<int, Dictionary<int, UserSkillGrowthInfoData>> UserSkillGrowthInfo { get; set; }
    [Key("UserSkillGrowthLevel")]
    public Dictionary<int, Dictionary<int, List<UserSkillGrowthLevelData>>> UserSkillGrowthLevel { get; set; }
    [Key("UserSkillGrowthSpend")]
    public Dictionary<int, Dictionary<int, List<UserSkillGrowthSpendData>>> UserSkillGrowthSpend { get; set; }
    [Key("UserSkillInfoGroup")]
    public Dictionary<int, List<UserSkillInfoData>> UserSkillInfoGroup { get; set; }
    [Key("VotingInfo")]
    public Dictionary<int, VotingInfo> VotingInfo { get; set; }
    [Key("VotingReward")]
    public Dictionary<int, VotingReward> VotingReward { get; set; }
    [Key("WaveAugmentDrawRate")]
    public Dictionary<int, WaveAugmentDrawRateData> WaveAugmentDrawRate { get; set; }
    [Key("WaveInfos")]
    public Dictionary<int, WaveInfoData> WaveInfos { get; set; }
    [Key("WebShopBonusProductData")]
    public Dictionary<int, List<WebShopBonusProductData>> WebShopBonusProductData { get; set; }
    [Key("WeeklyQuest")]
    public Dictionary<int, WeeklyQuestData> WeeklyQuest { get; set; }
    [Key("WorldBossRage")]
    public Dictionary<int, WorldBossRageData> WorldBossRage { get; set; }
    [Key("WorldInfo")]
    public Dictionary<int, WorldInfoData> WorldInfo { get; set; }
    [Key("WorldRuleList")]
    public Dictionary<int, WorldRuleData> WorldRuleList { get; set; }
    [Key("WWEContentsConfigs")]
    public Dictionary<int, WWEContentsConfigData> WWEContentsConfigs { get; set; }
    [Key("WWEInfo")]
    public Dictionary<int, WWEInfoData> WWEInfo { get; set; }
    [Key("WWEReward")]
    public Dictionary<int, WWERewardData> WWERewards { get; set; }
    [Key("WWERoundInfo")]
    public Dictionary<int, Dictionary<int, WWERoundInfoData>> WWERoundInfo { get; set; }
    [Key("WWEStatusBonus")]
    public Dictionary<int, WWEStatusBonusData> WWEStatusBonus { get; set; }
    [Key("ZhChsText")]
    public Dictionary<string, string> ZhChsText { get; set; }
    [Key("ZhChtText")]
    public Dictionary<string, string> ZhChtText { get; set; }
}
