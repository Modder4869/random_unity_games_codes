using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class StageInfoData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public ModeType Mode { get; set; }
    [Key(2)]
    public int WorldInfoUid { get; set; }
    [Key(3)]
    public int StageOrder { get; set; }
    [Key(4)]
    public StageDifficultyType Difficulty { get; set; }
    [Key(5)]
    public int MonsterStatusBonusGroup { get; set; }
    [Key(6)]
    public int RecommendPower { get; set; }
    [Key(7)]
    public int Stamina { get; set; }
    [Key(8)]
    public int DefaultMana { get; set; }
    [Key(9)]
    public short Wave { get; set; }
    [Key(10)]
    public int TeamBuildTime { get; set; }
    [Key(11)]
    public int BattleTime { get; set; }
    [Key(12)]
    public int FirstReward { get; set; }
    [Key(13)]
    public int[] Rewards { get; set; }
    [Key(14)]
    public bool DrawHeroCheck { get; set; }
    [Key(15)]
    public bool DrawArtifactCheck { get; set; }
    [Key(16)]
    public bool DrawSpellCheck { get; set; }
    [Key(17)]
    public int[] ClearConditionArray { get; set; }
    [Key(18)]
    public int TargetMonster { get; set; }
    [Key(19)]
    public int[] DisplayMonster { get; set; }
    [Key(20)]
    public string Name { get; set; }
    [Key(21)]
    public string Desc { get; set; }
    [Key(22)]
    public string Background { get; set; }
    [Key(23)]
    public int PreviousStageUid { get; set; }
    [Key(24)]
    public int NextStageUid { get; set; }
    [Key(25)]
    public int SummonDeathCount { get; set; }
    [Key(26)]
    public int DrawCount { get; set; }
    [Key(27)]
    public int ContentGroupID { get; set; }
    [Key(28)]
    public int StageNumber { get; set; }
    [Key(29)]
    public string BGM { get; set; }
    [Key(30)]
    public PersonalityType[] RecommendPersonality { get; set; }
    [Key(31)]
    public int SoloRaidTotalHp { get; set; }
    [Key(32)]
    public int ModeStamina { get; set; }
    [Key(33)]
    public bool StageRepeat { get; set; }
    [Key(34)]
    public int StartGrade { get; set; }
    [Key(35)]
    public int EndSlotWave { get; set; }
    [Key(36)]
    public EndSlotDifficult DifficultEndSlot { get; set; }
    [Key(37)]
    public bool DrawAuthorityCheck { get; set; }
    [Key(38)]
    public int[] WorldRule { get; set; }
    [Key(39)]
    public int AsideStamina { get; set; }
    [Key(40)]
    public ModeType DeckType { get; set; }
    [Key(41)]
    public int PlayReward { get; set; }
    [Key(42)]
    public bool LimitSkillRange { get; set; }
    [Key(43)]
    public bool IgnoreSection { get; set; }
    [Key(44)]
    public bool UseSynergy { get; set; }
    [Key(45)]
    public bool UseSubSynergy { get; set; }
    [Key(46)]
    public FixBattleType FixBattleType { get; set; }
    [Key(47)]
    public int FixBattleUid { get; set; }
    [Key(48)]
    public int Help { get; set; }
    [Key(49)]
    public bool IgnoreHeroBonus { get; set; }
    [Key(50)]
    public bool UseCounterPersonality { get; set; }
    [Key(51)]
    public int GuaranteeUid { get; set; }
    [Key(52)]
    public int GaugeIncreaseValue { get; set; }
    [Key(53)]
    public int FastRecommendPower { get; set; }
}
