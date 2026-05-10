using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SkillEnhanceData : TableItem<TableData> {
    [Key(0)]
    public int SkillLevel { get; set; }
    [Key(1)]
    public JobType Job { get; set; }
    [Key(2)]
    public int[] MaterialIdArray { get; set; }
    [Key(3)]
    public int[] MaterialCountArray { get; set; }
    [Key(4)]
    public int NeedGold { get; set; }
    [Key(5)]
    public SkillType SkillType { get; set; }
}
