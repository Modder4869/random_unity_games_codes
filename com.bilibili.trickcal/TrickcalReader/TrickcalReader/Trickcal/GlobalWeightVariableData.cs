using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class GlobalWeightVariableData {
    [Key(0)]
    public short UserMaxLevel { get; set; }
    [Key(1)]
    public int UserMaxLevelExpStackMinus { get; set; }
    [Key(2)]
    public int[] HeroUnlockIdCardCounts { get; set; }
    [Key(3)]
    public int IdCardExchangeRate1 { get; set; }
    [Key(4)]
    public int IdCardExchangeRate2 { get; set; }
    [Key(5)]
    public int IdCardExchangeRate3 { get; set; }
    [Key(6)]
    public int PassiveUnlockHeroRank { get; set; }
    [Key(7)]
    public short HeroMocaronMaxLevel { get; set; }
    [Key(8)]
    public short HeroMaxLevel { get; set; }
    [Key(9)]
    public short HeroMaxGradeUp { get; set; }
    [Key(10)]
    public short HeroMaxRank { get; set; }
    [Key(11)]
    public short HeroMaxEquipEnhanceGrade { get; set; }
    [Key(12)]
    public short HeroMaxGrow { get; set; }
    [Key(13)]
    public short HeroMaxAffinityLevel { get; set; }
    [Key(14)]
    public int EquipEnhanceNeedGold { get; set; }
    [Key(15)]
    public IntPercentData EquipEnhanceReturn { get; set; }
    [Key(16)]
    public Dictionary<int, int> EquipCreateNeedGolds { get; set; }
    [Key(17)]
    public Dictionary<int, int> EquipCreateNeedPowders { get; set; }
    [Key(18)]
    public Dictionary<SkillType, int> HeroMaxSkillLevel { get; set; }
    [Key(19)]
    public int Gacha1Price { get; set; }
    [Key(20)]
    public int Gacha10Price { get; set; }
    [Key(21)]
    public int GachaMileageCount { get; set; }
    [Key(22)]
    public Dictionary<int, int> GachaGradeWeightMap { get; set; }
    [Key(23)]
    public Dictionary<int, int> GachaGradePickUpWeightMap { get; set; }
    [Key(24)]
    public Dictionary<int, int> GachaGradeMileagePriceMap { get; set; }
    [Key(25)]
    public Dictionary<int, int> GachaGradeDuplicateIdCardCountMap { get; set; }
    [Key(26)]
    public long StaminaRecoveryTimeSeconds { get; set; }
    [Key(27)]
    public int StageEnterDefaultStamina { get; set; }
    [Key(28)]
    public IntPercentData HotTimeStageStaminaDiscountRate { get; set; }
    [Key(29)]
    public int QuestNormalStageEnterDefaultStamina { get; set; }
    [Key(30)]
    public int QuestHardStageEnterDefaultStamina { get; set; }
    [Key(31)]
    public int QuestVeryHardStageEnterDefaultStamina { get; set; }
    [Key(32)]
    public int QuestChallengeEnterDefaultStamina { get; set; }
    [Key(33)]
    public int SpellCard_ManageNum { get; set; }
    [Key(34)]
    public int ArtifactCard_ManageNum { get; set; }
    [Key(35)]
    public int CameraMoveRangeMax { get; set; }
    [Key(36)]
    public int SlotTripleCoinProb { get; set; }
    [Key(37)]
    public int SlotHeroSingleProb { get; set; }
    [Key(38)]
    public int SlotHeroDoubleProb { get; set; }
    [Key(39)]
    public int SlotHeroTripleProb { get; set; }
    [Key(40)]
    public int SlotCoinProb { get; set; }
    [Key(41)]
    public int SlotTripleCoinValue { get; set; }
    [Key(42)]
    public int SlotCoinValue { get; set; }
    [Key(43)]
    public float HeroSpRecoveryRate { get; set; }
    [Key(44)]
    public float MonsterSpRecoveryRate { get; set; }
    [Key(45)]
    public int GrowthScale { get; set; }
    [Key(46)]
    public int MiniScale { get; set; }
    [Key(47)]
    public int EliteScale { get; set; }
    [Key(48)]
    public int BossScale { get; set; }
    [Key(49)]
    public int WorldBossScale { get; set; }
    [Key(50)]
    public int MaxAddScale { get; set; }
    [Key(51)]
    public float MoveToBattleSpeed { get; set; }
    [Key(52)]
    public float MoveToBattleEndSpeed { get; set; }
    [Key(53)]
    public float BattleEndHeal { get; set; }
    [Key(54)]
    public float CounterValue { get; set; }
    [Key(55)]
    public float ReverseCounterValue { get; set; }
    [Key(56)]
    public float CounterValuePvp { get; set; }
    [Key(57)]
    public float ReverseCounterValuePvp { get; set; }
    [Key(58)]
    public float AttackSpeedMinRatio { get; set; }
    [Key(59)]
    public float DamageReduceMinRatio { get; set; }
    [Key(60)]
    public float HpRecoveryMinRatio { get; set; }
    [Key(61)]
    public float SpRecoveryMinRatio { get; set; }
    [Key(62)]
    public float AttackPowerMinRatio { get; set; }
    [Key(63)]
    public float CriticalMultMinRatio { get; set; }
    [Key(64)]
    public int ReRollCoinMin { get; set; }
    [Key(65)]
    public int CoinInterestCheck { get; set; }
    [Key(66)]
    public int CoinInterestCoin { get; set; }
    [Key(67)]
    public int CoinRich01 { get; set; }
    [Key(68)]
    public int CoinRich02 { get; set; }
    [Key(69)]
    public int CoinRich03 { get; set; }
    [Key(70)]
    public int CoinRich04 { get; set; }
    [Key(71)]
    public int[] RewardFreeMileageArtifactRarities { get; set; }
    [Key(72)]
    public int[] RewardFreeMileageSpellRarities { get; set; }
    [Key(73)]
    public int[] RewardPetFreeMileagePetRarities { get; set; }
    [Key(74)]
    public IntPercentData FoodAffinityFactorNormal { get; set; }
    [Key(75)]
    public IntPercentData FoodAffinityFactorHate { get; set; }
    [Key(76)]
    public IntPercentData FoodAffinityFactorLike { get; set; }
    [Key(77)]
    public int[] LifeSkillUnlockLevels { get; set; }
    [Key(78)]
    public IntPercentData TaskLifeSkillMatchBonusFactor { get; set; }
    [Key(79)]
    public IntPercentData TaskSuccessRateMin { get; set; }
    [Key(80)]
    public IntPercentData TaskStressFactor { get; set; }
    [Key(81)]
    public IntPercentData TaskTypePickByArbeitWeight { get; set; }
    [Key(82)]
    public IntPercentData TaskTypePickByRestWeight { get; set; }
    [Key(83)]
    public IntPercentData TaskPerfectRewardBonusFactor { get; set; }
    [Key(84)]
    public IntPercentData TaskFailRewardPenaltyFactor { get; set; }
    [Key(85)]
    public IntPercentData TaskPerfectRateMax { get; set; }
    [Key(86)]
    public IntPercentData TaskPerfectRateFactor { get; set; }
    [Key(87)]
    public IntPercentData TaskItemEventRateMin { get; set; }
    [Key(88)]
    public int LifeTaskRefreshAnyCashPrice { get; set; }
    [Key(89)]
    public int LifeTaskHeroResetAnyCashPrice { get; set; }
    [Key(90)]
    public IntPercentData LifeTaskRestRemoveNegativeConditionRate { get; set; }
    [Key(91)]
    public int LifeTaskPerfectRewardBonusMultiplier { get; set; }
    [Key(92)]
    public int[] LifeTaskPerfectRewardBonusCountWeights { get; set; }
    [Key(93)]
    public int LifeTaskPerfectRewardBonusCountAllWeight { get; set; }
    [Key(94)]
    public WeightedPicker<int> LifeTaskPerfectRewardBonusCountPicker { get; set; }
    [Key(95)]
    public int LifeTaskConditionDropRate100 { get; set; }
    [Key(96)]
    public IntPercentData TaskLifeSkillBonusFactor { get; set; }
    [Key(97)]
    public int LifeSkillMaxLevel { get; set; }
    [Key(98)]
    public int LifeMaxLevel { get; set; }
    [Key(99)]
    public IntPercentData[] GachaSpectacleFixedCountRates { get; set; }
    [Key(100)]
    public WeightedPicker<int> GachaSpectacleFixedCountPicker { get; set; }
    [Key(101)]
    public int SoloRaidMaxUltimateCount { get; set; }
    [Key(102)]
    public int PvpEldainMaxCount { get; set; }
    [Key(103)]
    public int Global_HeroAffinityReactionUnlock_HelpUid { get; set; }
    [Key(104)]
    public int Tutorial_Equip_Hero { get; set; }
    [Key(105)]
    public int[] PvpArenaCompetitionValues { get; set; }
    [Key(106)]
    public int PvpArenaRenewalRank { get; set; }
    [Key(107)]
    public int[] PvpArenaCompetitionHighValues { get; set; }
    [Key(108)]
    public int PvpArenaCompetitionUnderValue { get; set; }
    [Key(109)]
    public int PvpArenaGroupLimit { get; set; }
    [Key(110)]
    public int PvpArenaUserLimit { get; set; }
    [Key(111)]
    public int Tutorial_Schedule_Hero { get; set; }
    [Key(112)]
    public TimeSpan PvpArenaStackRewardInterval { get; set; }
    [Key(113)]
    public int PvpArenaStackRewardCheckTime { get; set; }
    [Key(114)]
    public int PvpArenaStackRewardMax { get; set; }
    [Key(115)]
    public (int, int)[] PvpArenaHeroHiddenCounts { get; set; }
    [Key(116)]
    public Goods PvpArenaTicketRefillPrice { get; set; }
    [Key(117)]
    public Goods PvpRankTicketRefillPrice { get; set; }
    [Key(118)]
    public int PvpArenaGrow { get; set; }
    [Key(119)]
    public int PvpRankGrow { get; set; }
    [Key(120)]
    public int PvpArenaUserListCount { get; set; }
    [Key(121)]
    public short PvpArenaDailyTicketCount { get; set; }
    [Key(122)]
    public TimeSpan PvpArenaSeasonProcessingDuration { get; set; }
    [Key(123)]
    public TimeSpan PvpArenaUserListExpireTime { get; set; }
    [Key(124)]
    public TimeSpan PvpArenaUserSelectExpireTime { get; set; }
    [Key(125)]
    public int TrickcalRankDailyCount { get; set; }
    [Key(126)]
    public int TrickcalRankDailyMaxRefillCount { get; set; }
    [Key(127)]
    public float TrickcalRankMatchingRate1 { get; set; }
    [Key(128)]
    public float TrickcalRankMatchingRate2 { get; set; }
    [Key(129)]
    public int TrickcalRankMatchingRanking { get; set; }
    [Key(130)]
    public int TrickcalRankBoxDrop1 { get; set; }
    [Key(131)]
    public int TrickcalRankBoxDrop2 { get; set; }
    [Key(132)]
    public int TrickcalRankBoxDrop3 { get; set; }
    [Key(133)]
    public int TrickcalRankBoxDrop4 { get; set; }
    [Key(134)]
    public int TrickcalRankBoxDelayTime1 { get; set; }
    [Key(135)]
    public int TrickcalRankBoxDelayTime2 { get; set; }
    [Key(136)]
    public int TrickcalRankBoxDelayTime3 { get; set; }
    [Key(137)]
    public int TrickcalRankBoxDelayTime4 { get; set; }
    [Key(138)]
    public int TrickcalRankBoxKeyUid { get; set; }
    [Key(139)]
    public int TrickcalRankBoxKeySaveTime { get; set; }
    [Key(140)]
    public int TrickcalRankBoxDiaSaveTime { get; set; }
    [Key(141)]
    public int PetInteractionOwnedMaxCount { get; set; }
    [Key(142)]
    public int PetInteractionNotOwnedMaxCount { get; set; }
    [Key(143)]
    public int PetInteractionPositionMax { get; set; }
    [Key(144)]
    public TimeSpan MyHomeDonationInterval { get; set; }
    [Key(145)]
    public TimeSpan ProductionMaxTime { get; set; }
    [Key(146)]
    public TimeSpan SoloRaidCalculateInterval { get; set; }
    [Key(147)]
    public int ProductionSlotDefaultCount { get; set; }
    [Key(148)]
    public int RestaurantSlotDefaultCount { get; set; }
    [Key(149)]
    public int DailyScheduleMaxCount { get; set; }
    [Key(150)]
    public int ScheduleTaskListCount { get; set; }
    [Key(151)]
    public int ShopPackageCheckRewardCount { get; set; }
    [Key(152)]
    public int ModeSkillEnhanceClearMax { get; set; }
    [Key(153)]
    public int ModeLevelUpClearMax { get; set; }
    [Key(154)]
    public int ModeGoldClearMax { get; set; }
    [Key(155)]
    public int ModeBoardClearMax { get; set; }
    [Key(156)]
    public int ModeUpgradeClearMax { get; set; }
    [Key(157)]
    public int ModeEquipPartClearMax { get; set; }
    [Key(158)]
    public int DailyQuestMaxCount { get; set; }
    [Key(159)]
    public int WeeklyQuestMaxCount { get; set; }
    [Key(160)]
    public int ShopRecommendFit3HeroCount { get; set; }
    [Key(161)]
    public int LoveHeroCoolTime { get; set; }
    [Key(162)]
    public int LoveHeroCoolTimeCancelPrice { get; set; }
    [Key(163)]
    public int GlobalMaxLoveHero { get; set; }
    [Key(164)]
    public Goods StageQuestWorldOpenNormalRewards { get; set; }
    [Key(165)]
    public Goods StageQuestWorldOpenHardRewards { get; set; }
    [Key(166)]
    public Goods StageQuestWorldOpenVeryHardRewards { get; set; }
    [Key(167)]
    public int RecommendPowerEasy { get; set; }
    [Key(168)]
    public int RecommendPowerHard { get; set; }
    [Key(169)]
    public Goods HelpReward { get; set; }
    [Key(170)]
    public int FriendMaxCount { get; set; }
    [Key(171)]
    public int FriendRequestMaxCount { get; set; }
    [Key(172)]
    public int FriendSocialPointSendMaxCount { get; set; }
    [Key(173)]
    public int FriendSocialPointReceiveMaxCount { get; set; }
    [Key(174)]
    public int FriendRecommendMaxCount { get; set; }
    [Key(175)]
    public int FriendSearchMaxCount { get; set; }
    [Key(176)]
    public TimeSpan FriendRecommendPlayTimeCondition { get; set; }
    [Key(177)]
    public TimeSpan FriendRecommendRecentLoginCondition { get; set; }
    [Key(178)]
    public int FriendSocialPointEventCount { get; set; }
    [Key(179)]
    public int FriendSocialPointEventNeedCount { get; set; }
    [Key(180)]
    public TimeSpan FriendSocialPointEventRemainTime { get; set; }
    [Key(181)]
    public int FriendCodeLength { get; set; }
    [Key(182)]
    public int FriendCodeGenerationMaxRetryCount { get; set; }
    [Key(183)]
    public int GatherHeroWhistle { get; set; }
    [Key(184)]
    public int GatherHeroShineWhistle { get; set; }
    [Key(185)]
    public int GatherHeroNeedItemId { get; set; }
    [Key(186)]
    public int GatherHeroOutstandingHeroStatusBonus { get; set; }
    [Key(193)]
    public TimeSpan TrickcalPassTimeout { get; set; }
    [Key(194)]
    public int PremiumPassPoint { get; set; }
    [Key(195)]
    public int SummonsCardMaxPoint { get; set; }
    [Key(196)]
    public Goods SummonsCardPointReward { get; set; }
    [Key(197)]
    public Dictionary<int, Goods> FurnitureExchangeItemCountByRarity { get; set; }
    [Key(198)]
    public Dictionary<int, Goods> CollectionExchangeItemCountByRarity { get; set; }
    [Key(199)]
    public int ModeUpgradeMaxPlayCount { get; set; }
    [Key(200)]
    public int ModeStaminaDailyRefillCount { get; set; }
    [Key(201)]
    public int ModeStaminaDailyRecorverCount { get; set; }
    [Key(202)]
    public int HeroLevelUpItem1 { get; set; }
    [Key(203)]
    public int HeroLevelUpItem2 { get; set; }
    [Key(204)]
    public int Global_Gacha_HeroEvent3 { get; set; }
    [Key(205)]
    public int Global_Gacha_HeroEvent1 { get; set; }
    [Key(206)]
    public int Global_Gacha_HeroEvent2 { get; set; }
    [Key(207)]
    public int HiddenPickupGachaRequiredCount { get; set; }
    [Key(208)]
    public int HiddenPickupCardRequiredCount { get; set; }
    [Key(209)]
    public int HiddenPickupSpecRequiredCount { get; set; }
    [Key(210)]
    public int SubscriptionBuyPossible { get; set; }
    [Key(211)]
    public int DialogueAffinityLow { get; set; }
    [Key(212)]
    public int DialogueAffinityMiddle { get; set; }
    [Key(213)]
    public int DialogueAffinityHigh { get; set; }
    [Key(214)]
    public int DialogueMoveSkip { get; set; }
    [Key(215)]
    public IntPercentData ThemeEventMaxBonusRate { get; set; }
    [Key(216)]
    public Goods ThemeEventCurrencyExchangeGoods { get; set; }
    [Key(217)]
    public int HardStageQuestOpenStageUid { get; set; }
    [Key(218)]
    public int VeryHardStageQuestOpenStageUid { get; set; }
    [Key(219)]
    public int TripleSpeedUnlock { get; set; }
    [Key(220)]
    public int TutorialGachaFixHeroId { get; set; }
    [Key(221)]
    public TimeSpan AccountWithdrawalGracePeriod { get; set; }
    [Key(222)]
    public int FirstBonusResetPoint { get; set; }
    [Key(223)]
    public TimeSpan ChangeNicknameCoolTime { get; set; }
    [Key(224)]
    public int GachaExchangeRatio { get; set; }
    [Key(225)]
    public int ThemeEventHardOpenDelay { get; set; }
    [Key(226)]
    public int ThemeEventVeryHardOpenDelay { get; set; }
    [Key(227)]
    public int ThemeEventChallengeOpenDelay { get; set; }
    [Key(228)]
    public float ScheduleQuickRate { get; set; }
    [Key(229)]
    public int ModeEquipPartClearMaxPlusShopUid { get; set; }
    [Key(230)]
    public int UserExpGoldExchangeRate { get; set; }
    [Key(231)]
    public int ExtraAppearChangeRate { get; set; }
    [Key(232)]
    public int BoardResetRequiredItemUid { get; set; }
    [Key(233)]
    public IntPercentData BoardResetReturnGoldRate { get; set; }
    [Key(234)]
    public int[] MyHomeLabNoDonationItems { get; set; }
    [Key(235)]
    public Goods DropEventCurrencyExchangeGoods { get; set; }
    [Key(236)]
    public Goods BingoEventCurrencyExchangeGoods { get; set; }
    [Key(237)]
    public IntPercentData LifeResetReturnExpRate { get; set; }
    [Key(238)]
    public int SpecialRewardEpisodeId { get; set; }
    [Key(239)]
    public Goods SpecialRewardGoods { get; set; }
    [Key(240)]
    public Goods GuildCreateRequiredGoods { get; set; }
    [Key(241)]
    public TimeSpan GuildJoinCoolTime { get; set; }
    [Key(242)]
    public TimeSpan GuildNamePreemptionCoolTime { get; set; }
    [Key(243)]
    public int GuildNameLengthMin { get; set; }
    [Key(244)]
    public int GuildNameLengthMax { get; set; }
    [Key(245)]
    public int GuildDescriptionLengthMin { get; set; }
    [Key(246)]
    public int GuildDescriptionLengthMax { get; set; }
    [Key(247)]
    public int GuildDescriptionMaxLineCount { get; set; }
    [Key(248)]
    public int GuildNoticeLengthMin { get; set; }
    [Key(249)]
    public int GuildNoticeLengthMax { get; set; }
    [Key(250)]
    public int GuildNoticeMaxLineCount { get; set; }
    [Key(251)]
    public int GuildMemberMaxCount { get; set; }
    [Key(252)]
    public int GuildCreateRequiredLevel { get; set; }
    [Key(253)]
    public int GuildRecommendMaxCount { get; set; }
    [Key(254)]
    public int GuildBeginnerSupportSendMaxCount { get; set; }
    [Key(255)]
    public int GuildBeginnerSupportReceiveLevelLimit { get; set; }
    [Key(256)]
    public TimeSpan GuildHeroRentCacheTimeout { get; set; }
    [Key(257)]
    public TimeSpan GuildHeroRentTimeout { get; set; }
    [Key(258)]
    public TimeSpan GuildMasterOfflineKickTimeout { get; set; }
    [Key(259)]
    public Goods[] GuildAttendanceRewards { get; set; }
    [Key(260)]
    public IntPercentData GuildPetInteractionRewardDropRate { get; set; }
    [Key(261)]
    public int GuildPetInteractionRewardMaxCount { get; set; }
    [Key(262)]
    public Goods GuildBeginnerSupportReceiveRewardGoods { get; set; }
    [Key(263)]
    public int GuildDefaultPetId { get; set; }
    [Key(264)]
    public Goods GuildHeroRentRewardGoods { get; set; }
    [Key(265)]
    public int GuildHeroRentDailyCountLimit { get; set; }
    [Key(266)]
    public int GuildHeroRentSeasonCountLimitForSoloRaid { get; set; }
    [Key(267)]
    public int GuildHeroRentRewardDayCountLimit { get; set; }
    [Key(268)]
    public int GuildHeroRentRewardMax { get; set; }
    [Key(269)]
    public int GuildHeroRentRewardMaxStackCount { get; set; }
    [Key(270)]
    public TimeSpan GuildNameChangeCoolTime { get; set; }
    [Key(271)]
    public Goods GuildPetInteractionRewards { get; set; }
    [Key(272)]
    public Goods GuildBeginnerSupportSendRewardGoods { get; set; }
    [Key(273)]
    public TimeSpan GuildBeginnerSupportReceiveRewardMailExpireTime { get; set; }
    [Key(274)]
    public int GuildJoinRequestMaxCount { get; set; }
    [Key(275)]
    public int EpisodeNeedGoodsUid { get; set; }
    [Key(276)]
    public TimeSpan SoloEndBossOpenTime { get; set; }
    [Key(277)]
    public int SoloEndNormalWorldEnterLimit { get; set; }
    [Key(278)]
    public LongPercentData SoloEndScoreRate { get; set; }
    [Key(279)]
    public TimeSpan SoloEndCalculateTime { get; set; }
    [Key(280)]
    public int SoloEndInGameCoinGoodsId { get; set; }
    [Key(281)]
    public short HeroStar1ActiveNodeMax { get; set; }
    [Key(282)]
    public short HeroActiveNodeMax { get; set; }
    [Key(283)]
    public int SystemConfig_UseRuntimeDownload { get; set; }
    [Key(284)]
    public int RerunStageOpenRequiredGoodsType { get; set; }
    [Key(285)]
    public int RerunStageOpenRequiredGoodsValue { get; set; }
    [Key(286)]
    public int GuildRecommendJoinRatio01 { get; set; }
    [Key(287)]
    public int GuildRecommendJoinRatio02 { get; set; }
    [Key(288)]
    public int GuildRecommendJoinRatio03 { get; set; }
    [Key(289)]
    public float SystemConfig_RuntimeDownloadIntervalWhileInPatch { get; set; }
    [Key(290)]
    public int SystemConfig_MaxAssetBundlePatchConnections { get; set; }
    [Key(291)]
    public int SystemConfig_AllowToResetAssetBundles { get; set; }
    [Key(292)]
    public int MiniGameLeetsMaxSizeUp { get; set; }
    [Key(293)]
    public bool TrainingRoomAvailableFullPowerSetting { get; set; }
    [Key(294)]
    public int SoloRaidSaveStageCount { get; set; }
    [Key(295)]
    public int MainLobbyCustomCount { get; set; }
    [Key(296)]
    public int MainLobbyCustomHeroCount { get; set; }
    [Key(297)]
    public int SystemConfig_UseStreamingVideo { get; set; }
    [Key(298)]
    public int SystemConfig_StandardOfLowEndDeviceMemory { get; set; }
    [Key(299)]
    public int MyHomeRestaurantDigestItemCount { get; set; }
    [Key(300)]
    public int MyHomeRestaurantDigestCash { get; set; }
    [Key(301)]
    public int MyHomeRestaurantMaxEatCount { get; set; }
    [Key(302)]
    public int Schedule_DefaultTaskSelectNum { get; set; }
    [Key(303)]
    public int Schedule_NightTaskSelectNum { get; set; }
    [Key(304)]
    public int Global_NightShiftCash { get; set; }
    [Key(305)]
    public bool AppConfigIsLiveEnable { get; set; }
    [Key(307)]
    public int MainLobbyDefaultCount { get; set; }
    [Key(308)]
    public float MemoryPieceZoomMax { get; set; }
    [Key(309)]
    public Dictionary<int, Goods> LobbyBackgroundExchangeItemCountByRarity { get; set; }
    [Key(310)]
    public int PetDispatchTaskMaxPetCount { get; set; }
    [Key(311)]
    public int GuildPetRentDayLimit { get; set; }
    [Key(312)]
    public Goods GuildPetRentRewardGoods { get; set; }
    [Key(313)]
    public int GuildPetRentRewardDayCountLimit { get; set; }
    [Key(324)]
    public int GuildPetRentRewardMaxStackCount { get; set; }
    [Key(325)]
    public TimeSpan GuildPetRentCacheTimeout { get; set; }
    [Key(326)]
    public TimeSpan GuildPetRentTimeout { get; set; }
    [Key(327)]
    public int GachaHistorySaveDays { get; set; }
    [Key(328)]
    public int GachaHistorySaveCount { get; set; }
    [Key(329)]
    public int GuildPetRentRewardMax { get; set; }
    [Key(330)]
    public int AsideGradeMax { get; set; }
    [Key(331)]
    public int AsideLevelMax { get; set; }
    [Key(332)]
    public Dictionary<TribeType, int> AsideExpGoods { get; set; }
    [Key(333)]
    public int AsideStaminaDailyRecorverCount { get; set; }
    [Key(334)]
    public IntPercentData AsideLevelUpTribeMatchBonus { get; set; }
    [Key(335)]
    public IntPercentData AsideLevelUpTribeMatchTotal { get; set; }
    [Key(337)]
    public int ModeUpgradeModeStaminaReduceShopUid { get; set; }
    [Key(338)]
    public int ModeUpgradeReducedModeStaminaCount { get; set; }
    [Key(339)]
    public int ModeAsideStaminaReduceShopUid { get; set; }
    [Key(340)]
    public int ModeAsideReducedStaminaCount { get; set; }
    [Key(341)]
    public int GuildHeroRentSeasonCountLimitForGlobalBattleEventBoss { get; set; }
    [Key(342)]
    public int GlobalBattleEventBossTimeBonus { get; set; }
    [Key(343)]
    public int PvpForceDefeatTime { get; set; }
    [Key(344)]
    public IntPercentData SoloRaidScoreRate { get; set; }
    [Key(345)]
    public int SoloRaidTimeBonusValue { get; set; }
    [Key(346)]
    public TimeSpan PvpLoadingOverTime { get; set; }
    [Key(347)]
    public int ResourceOccupyEventMinValueToReceive { get; set; }
    [Key(348)]
    public TimeSpan ResourceOccupyEventGenerateTime { get; set; }
    [Key(349)]
    public TimeSpan ResourceOccupyEventMaxCumulativeTime { get; set; }
    [Key(350)]
    public int ResourceOccupyEventMaxCumulativeCount { get; set; }
    [Key(351)]
    public TimeSpan AugmentChallengeOpenDelay { get; set; }
    [Key(352)]
    public int AugmentChallengeHighAugmentOptionValue { get; set; }
    [Key(353)]
    public int AugmentChallengeExpDropRadius { get; set; }
    [Key(354)]
    public int AugmentChallengeAugmentReRollValue { get; set; }
    [Key(355)]
    public int AugmentChallengeNotEnoughAugmentPool { get; set; }
    [Key(356)]
    public int AugmentChallengeAutoSelectDelayMs { get; set; }
    [Key(357)]
    public int AugmentChallengeHighAugmentMinValue { get; set; }
    [Key(358)]
    public int RenewaMiniGame_MaxScoreTimeRange { get; set; }
    [Key(359)]
    public int RenewaMiniGame_TimeRange { get; set; }
    [Key(360)]
    public int RenewaMiniGame_DecreaseScoreRate { get; set; }
    [Key(361)]
    public int RenewaMiniGame_MaxScore { get; set; }
    [Key(362)]
    public int Global_Schedule_RunStress { get; set; }
    [Key(363)]
    public IntPercentData Global_Schedule_RunProb { get; set; }
    [Key(364)]
    public int Global_Schedule_FeverCount { get; set; }
    [Key(365)]
    public IntPercentData Global_Schedule_SpecialRestProb { get; set; }
    [Key(366)]
    public IntPercentData Global_Schedule_StoryEventProb { get; set; }
    [Key(367)]
    public int Global_Schedule_GetAffinity { get; set; }
    [Key(368)]
    public int Schedule_CanUseHeroOnlyOnce { get; set; }
    [Key(369)]
    public int Global_DailyStressRecovery_Default { get; set; }
    [Key(370)]
    public int Global_FoodFirstTasteBonus { get; set; }
    [Key(371)]
    public int ForceEnableBattleValidation { get; set; }
    [Key(372)]
    public IntPercentData FoodAffinityFactorVeryLike { get; set; }
    [Key(378)]
    public int FirstAnniversaryMemoryShareReward { get; set; }
    [Key(379)]
    public int SoloRaidEldainMaxCount { get; set; }
    [Key(380)]
    public int CardMaxLevel { get; set; }
    [Key(381)]
    public int FriendRecommendMinimumLevel { get; set; }
    [Key(387)]
    public int ButterMiniGameScrollSpeed { get; set; }
    [Key(388)]
    public int ButterMiniGameSimultaneousMsRange { get; set; }
    [Key(389)]
    public int ButterMiniGameHpMax { get; set; }
    [Key(390)]
    public int ButterMiniGameFeverMax { get; set; }
    [Key(391)]
    public int ButterMiniGameFeverDuration { get; set; }
    [Key(392)]
    public IntPercentData ButterMiniGameFeverScoreRate { get; set; }
    [Key(393)]
    public int GlobalGachaHeroPickUpMileageItem { get; set; }
    [Key(394)]
    public int GlobalGachaCardPickUpMileageItem { get; set; }
    [Key(395)]
    public int FriendRecommendMinimumStageId { get; set; }
    [Key(396)]
    public int GlobalGachaHeroMileageItem { get; set; }
    [Key(397)]
    public int GlobalGachaCardMileageItem { get; set; }
    [Key(398)]
    public int GlobalAppearCountLow { get; set; }
    [Key(399)]
    public int GlobalAppearCountMiddle { get; set; }
    [Key(400)]
    public int MainRecipeCategory_Material { get; set; }
    [Key(401)]
    public int MainRecipeCategory_Skin { get; set; }
    [Key(402)]
    public int MainRecipeCategory_Kitchen { get; set; }
    [Key(403)]
    public int ProductionSkinSlotDefaultCount { get; set; }
    [Key(404)]
    public int MaxWindowLimit { get; set; }
    [Key(405)]
    public int MaxPopupLimit { get; set; }
    [Key(408)]
    public int GlobalBeginnerGachaDrop { get; set; }
    [Key(409)]
    public int VotingTime { get; set; }
    [Key(410)]
    public int VotingEventResultCycle { get; set; }
    [Key(411)]
    public int[] AffinityRelationSteps { get; set; }
    [Key(412)]
    public int Global_Schedule_StoryEvent_LifeLevel1 { get; set; }
    [Key(413)]
    public int[] DefaultDeckHeroes { get; set; }
    [Key(420)]
    public int IdCardExchangeSpecial { get; set; }
    [Key(421)]
    public int AutoBattleUnlock { get; set; }
    [Key(422)]
    public int GlobalRerollCost { get; set; }
    [Key(423)]
    public int GlobalRerollCostUp { get; set; }
    [Key(424)]
    public int GlobalRerollCostLimit { get; set; }
    [Key(425)]
    public float GlobalColorfulCardCost { get; set; }
    [Key(426)]
    public float GlobalColorfulCardSuccessRate { get; set; }
    [Key(427)]
    public float GlobalColorfulCardFailRate { get; set; }
    [Key(428)]
    public int AutoBattleUnlockWorldUid { get; set; }
    [Key(429)]
    public int AutoBattleUnlockStageOrder { get; set; }
    [Key(430)]
    public int AutoBattleUnlockDifficulty { get; set; }
    [Key(431)]
    public int TripleSpeedUnlockWorldUid { get; set; }
    [Key(432)]
    public int TripleSpeedUnlockStageOrder { get; set; }
    [Key(433)]
    public int TripleSpeedUnlockDifficulty { get; set; }
    [Key(434)]
    public int UltimateUnlockWorldUid { get; set; }
    [Key(435)]
    public int UltimateUnlockStageOrder { get; set; }
    [Key(436)]
    public int UltimateUnlockDifficulty { get; set; }
    [Key(437)]
    public int UltimateUnlockStageUid { get; set; }
    [Key(438)]
    public int UltimateUnlockWave { get; set; }
    [Key(439)]
    public int DeckEditUnlockWorldUid { get; set; }
    [Key(440)]
    public int DeckEditUnlockStageOrder { get; set; }
    [Key(441)]
    public int DeckEditUnlockDifficulty { get; set; }
    [Key(442)]
    public int DeckEditUnlockStageUid { get; set; }
    [Key(443)]
    public int FlatMaxPurchaseCount { get; set; }
    [Key(444)]
    public int DoubleSpeedUnlockWorldUid { get; set; }
    [Key(445)]
    public int DoubleSpeedUnlockStageOrder { get; set; }
    [Key(446)]
    public int DoubleSpeedUnlockDifficulty { get; set; }
    [Key(447)]
    public int DoubleSpeedUnlockStageUid { get; set; }
    [Key(448)]
    public int DonationHiddenActiveLv { get; set; }
    [Key(449)]
    public int DonationHiddenCount { get; set; }
    [Key(450)]
    public int DonationHiddenRewardUid { get; set; }
    [Key(451)]
    public int DonationHiddenRewardValue { get; set; }
    [Key(452)]
    public int RanMiniGameComboScore { get; set; }
    [Key(453)]
    public int RanMiniGameComboMinFoodCount { get; set; }
    [Key(454)]
    public int RanMiniGameButterPenaltyTime { get; set; }
    [Key(455)]
    public int RanMiniGamePointerDisappearTime { get; set; }
    [Key(456)]
    public Goods UserBirthdayRewardGoods { get; set; }
    [Key(457)]
    public int RanMiniGameRankSaveLimit { get; set; }
    [Key(458)]
    public DateTime BirthdayCheckStartTime { get; set; }
    [Key(459)]
    public int RanMiniGameComboAddRate11 { get; set; }
    [Key(460)]
    public int RanMiniGameComboAddRate12 { get; set; }
    [Key(461)]
    public float RanMiniGameComboTimeIncrease { get; set; }
    [Key(462)]
    public bool IsLoveHeroContainsEldain { get; set; }
    [Key(463)]
    public int SystemConfig_UsePackageDownloadForNewInstall { get; set; }
    [Key(464)]
    public int SystemConfig_UsePackageDownloadForPatching { get; set; }
    [Key(465)]
    public int SystemConfig_MaxAssetBundlePackageConnections { get; set; }
    [Key(466)]
    public int FlatProductExtendCheckDay { get; set; }
    [Key(467)]
    public TimeSpan SkinPassTimeout { get; set; }
    [Key(468)]
    public int SystemConfig_UsePackageDownloadForSelectiveDLCs { get; set; }
    [Key(469)]
    public bool SystemConfig_UseGlobalFXEffectMaxCount { get; set; }
    [Key(470)]
    public int SystemConfig_GlobalFXEffectMaxCount { get; set; }
    [Key(471)]
    public int AliceLotteryCuriosCardProb { get; set; }
    [Key(472)]
    public int ChaosArenaAttackCardCost { get; set; }
    [Key(473)]
    public int ChaosArenaDefenseCardCost { get; set; }
    [Key(474)]
    public int HeroPatInteractionVoiceFixUnlockAffinityLevel { get; set; }
    [Key(475)]
    public int ChaosArenaDailyMaxPlayCount { get; set; }
    [Key(476)]
    public int ChaosArenaDailyRewardPlayCount { get; set; }
    [Key(477)]
    public Goods ChaosArenaDailyRewardGoods { get; set; }
    [Key(478)]
    public IntPercentData ChaosArenaMatchingScoreRate1 { get; set; }
    [Key(479)]
    public IntPercentData ChaosArenaMatchingScoreRate2 { get; set; }
    [Key(480)]
    public int ChaosArenaMatchingMaxSecond { get; set; }
    [Key(481)]
    public int ChaosArenaMatchingMinSecond { get; set; }
    [Key(482)]
    public int ChaosArenaDuplicateMatchLimit { get; set; }
    [Key(483)]
    public int ChaosArenaMatchingRankingRate { get; set; }
    [Key(484)]
    public int CouponIpCheckMinutes { get; set; }
    [Key(485)]
    public int CouponIpCheckMaxRequestCount { get; set; }
    [Key(486)]
    public int CouponIpCheckCoolTimeMinutes { get; set; }
    [Key(487)]
    public int ChaosArenaDefaultScore { get; set; }
    [Key(488)]
    public int ChaosArenaMaxScore { get; set; }
    [Key(489)]
    public int MiniGameVelaFeverGauge { get; set; }
    [Key(490)]
    public int MiniGameVelaFeverFeverDuration { get; set; }
    [Key(491)]
    public int MiniGameVelaSpecialDisappearDuration { get; set; }
    [Key(492)]
    public int MiniGameVelaSpecialHitCount { get; set; }
    [Key(493)]
    public float MiniGameVelaDisappearWaitingTime { get; set; }
    [Key(494)]
    public IntPercentData ChaosArenaMatchingRankingRateValue { get; set; }
    [Key(495)]
    public int BingoEventExpandAllFlipMinBoard { get; set; }
    [Key(496)]
    public int BingoEventExpandAllFlipDecreaseCost { get; set; }
    [Key(497)]
    public int BingoEventExpandAllFlipCost { get; set; }
    [Key(498)]
    public int ChaosArenaMaxPlusScale { get; set; }
    [Key(499)]
    public int ThemeEventDailyLotteryMaxRewardGrade { get; set; }
    [Key(500)]
    public int ThemeEventDailyLotteryCalculateStartTime { get; set; }
    [Key(501)]
    public bool MaintenanceAllowActionCheck { get; set; }
    [Key(502)]
    public Goods LobbyBattleBtnExchangeGoods { get; set; }
    [Key(503)]
    public TimeSpan CookingTycoonCalculateTime { get; set; }
    [Key(504)]
    public int SystemConfig_IgnoreRedownloadAfterReconnection { get; set; }
    [Key(505)]
    public float CookingTycoonLeftTimeScoreMultiplier { get; set; }
    [Key(506)]
    public int ExchangeIdCard_NeedAmount_Eldain { get; set; }
    [Key(507)]
    public int ExchangeIdCard_GetAmount_Eldain { get; set; }
    [Key(508)]
    public int ExchangeIdCard_NeedAmount_Grade3 { get; set; }
    [Key(509)]
    public int ExchangeIdCard_GetAmount_Grade3 { get; set; }
    [Key(510)]
    public int ExchangeIdCard_NeedAmount_Grade2 { get; set; }
    [Key(511)]
    public int ExchangeIdCard_GetAmount_Grade2 { get; set; }
    [Key(512)]
    public int CookingTycoonTopRankingViewCount { get; set; }
    [Key(513)]
    public int InAppMailExpireTimeDays { get; set; }
    [Key(514)]
    public string ShopProductPlayPointsPromotionSuffix { get; set; }
    [Key(515)]
    public bool IsShowDummyRanking { get; set; }
    [Key(516)]
    public bool HasOneGroupOnly { get; set; }
    [Key(518)]
    public TimeSpan WWE_CheerUpdateTime { get; set; }
    [Key(519)]
    public TimeSpan WWE_CheerUnrevealedTime { get; set; }
    [Key(520)]
    public TimeSpan WWE_CheerDeadLineMinute { get; set; }
    [Key(521)]
    public int MiniGameDianaYesterErrorScore { get; set; }
    [Key(522)]
    public float SystemConfig_ANRWatchdogThreshold { get; set; }
    [Key(523)]
    public int SystemConfig_ANRWatchdogLogLimit { get; set; }
    [Key(524)]
    public int LeaderboardMax { get; set; }
    [Key(525)]
    public TimeSpan ArcadeSeasonCalculateTime { get; set; }
    [Key(526)]
    public int ArcadeSeasonTopRankingViewCount { get; set; }
    [Key(527)]
    public int MiniGame_EdEdition_MonsterMoveSpeedLimitValue { get; set; }
    [Key(528)]
    public int MiniGame_EdEdition_MoveSpeedDownLimitValue { get; set; }
    [Key(529)]
    public int MiniGame_EdEdition_MonsterDamageReceiveDownPercentLimitValue { get; set; }
    [Key(530)]
    public int MiniGame_EdEdition_UnitAttackSpeedLimitValue { get; set; }
    [Key(531)]
    public int MiniGame_EdEdition_UnitBardGachaLimit { get; set; }
    [Key(532)]
    public int MiniGame_EdEdition_ActiveSkillCommonCooltime { get; set; }
    [Key(533)]
    public int MiniGame_EdEdition_TimeBonus { get; set; }
    [Key(534)]
    public float TowerBattleAddHeight { get; set; }
    [Key(535)]
    public float TowerBattleObjectMoveMax { get; set; }
    [Key(536)]
    public TimeSpan TowerBattleEmotionCoolTime { get; set; }
    [Key(537)]
    public int TowerBattleScoreWeight { get; set; }
    [Key(538)]
    public int TowerBattleWinStreakScore { get; set; }
    [Key(539)]
    public int TowerBattleWinStreakScoreMax { get; set; }
    [Key(540)]
    public int TowerBattleDailyPlayLimit { get; set; }
    [Key(541)]
    public int TowerBattleMaxObjectChangeCount { get; set; }
    [Key(542)]
    public float TowerBattleEndObjectY { get; set; }
    [Key(543)]
    public float TowerBattleRotationSpeed { get; set; }
    [Key(544)]
    public int TowerBattleMatchGroupDelay { get; set; }
    [Key(545)]
    public int TowerBattleMatchFirstDelay { get; set; }
    [Key(546)]
    public IntPercentData TowerBattleMatchGroup1ScoreRate { get; set; }
    [Key(547)]
    public IntPercentData TowerBattleMatchGroup2ScoreRate { get; set; }
    [Key(548)]
    public int TowerBattleMatchMaxTime { get; set; }
    [Key(549)]
    public int TowerBattlePenaltyReduceScore { get; set; }
    [Key(550)]
    public int TowerBattlePenaltyCount { get; set; }
    [Key(551)]
    public int TowerBattleConfig_TargetFps { get; set; }
    [Key(552)]
    public int TowerBattleConfig_SubStepCount { get; set; }
    [Key(553)]
    public int TowerBattleWorldSleepTimeout { get; set; }
    [Key(554)]
    public float TowerBattleSleepVelocityThreshold { get; set; }
    [Key(555)]
    public TimeSpan TowerBattleReconnectWaitingTime { get; set; }
    [Key(556)]
    public TimeSpan TowerBattlePlayerReadyWaitingTime { get; set; }
    [Key(557)]
    public int TowerBattleConfig_KeepAliveIntervalSeconds { get; set; }
    [Key(558)]
    public int TowerBattlePlayPenaltyCount { get; set; }
    [Key(559)]
    public int TowerBattlePlayerReadWaitTimeSecond { get; set; }
    [Key(560)]
    public int TowerBattleNextDayAlarmMin { get; set; }
    [Key(561)]
    public int TowerBattleConfig_PhysicsSampleRate { get; set; }
    [Key(562)]
    public TimeSpan TowerBattleChangeObjectAddTimeSeconds { get; set; }
    [Key(563)]
    public int TowerBattleLoseScoreWeight { get; set; }
    [Key(564)]
    public TimeSpan ThemePassTimeout { get; set; }
    [Key(565)]
    public int TrainingRoomPlayListValue { get; set; }
    [Key(566)]
    public bool MyHomePetUseCodeAfterRefactoring { get; set; }
}
