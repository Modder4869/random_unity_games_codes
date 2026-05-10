using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class FixHeroSetGroupData : TableItem<TableData> {
    [Key(0)]
    public int GroupUid { get; set; }
    [Key(1)]
    public int HeroUid { get; set; }
    [Key(2)]
    public int HeroLevel { get; set; }
    [Key(3)]
    public int HeroGrade { get; set; }
    [Key(4)]
    public int GatherHeroLevel { get; set; }
    [Key(5)]
    public int AffinityLevel { get; set; }
    [Key(6)]
    public int LowSkillLevel { get; set; }
    [Key(7)]
    public int HighSkillLevel { get; set; }
    [Key(8)]
    public int HeroRank { get; set; }
    [Key(9)]
    public bool EquipState { get; set; }
    [Key(10)]
    public int EnhanceLevel { get; set; }
    [Key(11)]
    public int BoardCount { get; set; }
    [Key(12)]
    public int SkinUid { get; set; }
    [Key(13)]
    public bool AsideOwns { get; set; }
    [Key(14)]
    public short AsideGrade { get; set; }
    [Key(15)]
    public int AsideLevel { get; set; }
    [Key(16)]
    public short PassiveSkillLevel { get; set; }
    [Key(17)]
    public short GlobalPassiveSkillLevel { get; set; }
}
