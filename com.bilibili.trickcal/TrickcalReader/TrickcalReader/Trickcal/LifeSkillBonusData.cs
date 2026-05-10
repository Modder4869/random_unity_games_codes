using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class LifeSkillBonusData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int DemandLifeSkillNum { get; set; }
    [Key(2)]
    public int MainLifeSkill { get; set; }
    [Key(3)]
    public int SubLifeSkill { get; set; }
    [Key(4)]
    public int ArbeitAddSuccessProb { get; set; }
    [Key(5)]
    public int ArbeitRewardEventProb { get; set; }
    [Key(6)]
    public int RestAddSuccessProb { get; set; }
    [Key(7)]
    public int RestRewardEventProb { get; set; }
}
