using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class EventUnitLevelGroupData : TableItem<TableData> {
    [Key(0)]
    public int UnitUid { get; set; }
    [Key(1)]
    public int ActiveSkillUid { get; set; }
    [Key(2)]
    public int UltimateSkillUid { get; set; }
    [Key(3)]
    public int PassiveSkillUid { get; set; }
    [Key(4)]
    public int[] StatGroupUids { get; set; }
    [Key(5)]
    public string[] StatGroupIcons { get; set; }
    [Key(6)]
    public string PassiveSkillIcon { get; set; }
    [Key(7)]
    public string SpSkillIcon { get; set; }
    [Key(8)]
    public string UltimateSkillIcon { get; set; }
    [Key(9)]
    public string SpSkillName { get; set; }
    [Key(10)]
    public string UltimateSkillName { get; set; }
    [Key(11)]
    public string PassiveSkillName { get; set; }
    [Key(12)]
    public string[] StatGroupNames { get; set; }
    [Key(13)]
    public string EventUnitUpgradeText { get; set; }
    [Key(14)]
    public string EventUnitGrowthText { get; set; }
}
