using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class CallUnitData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int StageInfoUid { get; set; }
    [Key(2)]
    public int HeroInfoUid { get; set; }
    [Key(3)]
    public int Level { get; set; }
    [Key(4)]
    public int SPSkillLevel { get; set; }
    [Key(5)]
    public int UltimateSkillLevel { get; set; }
    [Key(8)]
    public int WaveOrder { get; set; }
    [Key(9)]
    public int Grade { get; set; }
    [Key(10)]
    public int Grow { get; set; }
    [Key(11)]
    public string Tag { get; set; }
}
