using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TestSettingData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int UserLevel { get; set; }
    [Key(2)]
    public int HeroSetGroupUid { get; set; }
    [Key(3)]
    public int GatherHeroLevel { get; set; }
    [Key(4)]
    public int AffinityLevel { get; set; }
    [Key(5)]
    public int LowSkillLevel { get; set; }
    [Key(6)]
    public int HighSkillLevel { get; set; }
    [Key(7)]
    public int HeroGrade { get; set; }
    [Key(8)]
    public int CardLevel { get; set; }
    [Key(9)]
    public int PassiveSkillLevel { get; set; }
}
