using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class HeroInfoData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int GradeDefault { get; set; }
    [Key(2)]
    public AttackType AttackType { get; set; }
    [Key(3)]
    public RangeType RangeType { get; set; }
    [Key(4)]
    public SectionType Section { get; set; }
    [Key(5)]
    public int Position { get; set; }
    [Key(6)]
    public JobType Job { get; set; }
    [Key(7)]
    public int ItemSlotCount { get; set; }
    [Key(8)]
    public PersonalityType Personality { get; set; }
    [Key(9)]
    public TribeType Tribe { get; set; }
    [Key(10)]
    public bool UnMoveType { get; set; }
    [Key(11)]
    public int GaugeOffense { get; set; }
    [Key(12)]
    public int GaugeDefense { get; set; }
    [Key(13)]
    public int GaugeUtility { get; set; }
    [Key(14)]
    public string Name { get; set; }
    [Key(15)]
    public string Desc { get; set; }
    [Key(16)]
    public string Icon { get; set; }
    [Key(17)]
    public string SpineBattle { get; set; }
    [Key(18)]
    public string SpineStanding { get; set; }
    [Key(19)]
    public string Portrait { get; set; }
    [Key(20)]
    public string KeyColor { get; set; }
    [Key(21)]
    public bool Available { get; set; }
    [Key(22)]
    public int Scale { get; set; }
    [Key(23)]
    public string Apology { get; set; }
    [Key(24)]
    public string LoveHeroTalk { get; set; }
    [Key(25)]
    public string LoveHeroCancelTalk { get; set; }
    [Key(26)]
    public string[] MatchingTalk { get; set; }
    [Key(27)]
    public int UserProfile { get; set; }
    [Key(28)]
    public string HeroGroup { get; set; }
    [Key(29)]
    public HiddenGachaType HiddenGachaType { get; set; }
    [Key(30)]
    public HeroSpecialGradeType SpecialGrade { get; set; }
    [Key(31)]
    public string[] DefeatText { get; set; }
    [Key(32)]
    public string ResourceName { get; set; }
    [Key(33)]
    public int ScaleRatio { get; set; }
    [Key(34)]
    public float ActiveSkillValueA { get; set; }
    [Key(35)]
    public float UltimateSkillValueA { get; set; }
    [Key(36)]
    public float PassiveValueA { get; set; }
    [Key(37)]
    public float WeightValueA { get; set; }
    [Key(38)]
    public HighPersonalityUnlockType HighPersonalityUnlock { get; set; }
    [Key(39)]
    public string[] HighPersonalityUnlockParam { get; set; }
    [Key(40)]
    public string HighPersonalityUid { get; set; }
}
