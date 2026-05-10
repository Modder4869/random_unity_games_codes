using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class GlobalSkillEventData : TableItem<TableData> {
    [Key(0)]
    public string Uid { get; set; }
    [Key(1)]
    public int Order { get; set; }
    [Key(2)]
    public int[] Frames { get; set; }
    [Key(3)]
    public string ObjectUid { get; set; }
    [Key(4)]
    public TargetGroupType ObjectTargetGroup { get; set; }
    [Key(5)]
    public TargetConditionType ObjectTargetCondition { get; set; }
    [Key(6)]
    public double ObjectTargetConditionValue { get; set; }
    [Key(7)]
    public string[] ActionUids { get; set; }
    [Key(8)]
    public string AniName { get; set; }
    [Key(9)]
    public TargetSectionType TargetSection { get; set; }
    [Key(10)]
    public TargetJobType TargetJob { get; set; }
    [Key(11)]
    public TargetPersonalityType TargetPersonality { get; set; }
    [Key(12)]
    public TargetTribeType TargetTribe { get; set; }
}
