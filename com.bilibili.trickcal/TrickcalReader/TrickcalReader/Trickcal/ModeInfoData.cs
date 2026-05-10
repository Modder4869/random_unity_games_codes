using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ModeInfoData : TableItem<TableData> {
    [Key(0)]
    public ModeType ModeType { get; set; }
    [Key(1)]
    public int WorldUid { get; set; }
    [Key(2)]
    public int DeckPresetUid { get; set; }
    [Key(3)]
    public int DeckPresetCount { get; set; }
    [Key(4)]
    public JobType[] HeroJobLimits { get; set; }
    [Key(5)]
    public PersonalityType RequiredPersonality { get; set; }
    [Key(6)]
    public int EldainLimitCount { get; set; }
    [Key(7)]
    public DeckHeroCountConditionType HeroCountCondition { get; set; }
    [Key(8)]
    public int HeroCount { get; set; }
    [Key(9)]
    public bool HeroMaxWarning { get; set; }
    [Key(10)]
    public int CardDeckPresetCount { get; set; }
    [Key(11)]
    public DeckCheckType DeckCheck { get; set; }
    [Key(12)]
    public int CardDeckPresetUid { get; set; }
    [Key(13)]
    public int CardHandCount { get; set; }
    [Key(14)]
    public int FastStartGrade { get; set; }
    [Key(15)]
    public int FastDefaultMana { get; set; }
    [Key(16)]
    public int FastTeamBuildTime { get; set; }
    [Key(17)]
    public int FastBattleTime { get; set; }
    [Key(18)]
    public int FastStartSpawnOrder { get; set; }
}
