using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class GlobalSkillHandlerData : TableItem<TableData> {
    [Key(0)]
    public string Uid { get; set; }
    [Key(1)]
    public string ActionModule { get; set; }
    [Key(2)]
    public string[] Params { get; set; }
    [Key(3)]
    public TargetGroupType TargetGroup { get; set; }
    [Key(4)]
    public TargetConditionType TargetCondition { get; set; }
    [Key(5)]
    public double TargetConditionValue { get; set; }
    [Key(6)]
    public HitBoxType HitBoxType { get; set; }
    [Key(7)]
    public double HitBoxWidth { get; set; }
    [Key(8)]
    public double HitBoxLength { get; set; }
    [Key(9)]
    public HitBoxoffset HitBoxOffsetType { get; set; }
    [Key(10)]
    public double HitBoxOffsetX { get; set; }
    [Key(11)]
    public string[] SelfObjectUids { get; set; }
    [Key(12)]
    public string LevelUid { get; set; }
    [Key(13)]
    public string[] PostSkills { get; set; }
    [Key(14)]
    public string[] PostSkillActions { get; set; }
    [Key(15)]
    public TargetSectionType TargetSection { get; set; }
    [Key(16)]
    public TargetJobType TargetJob { get; set; }
    [Key(17)]
    public TargetPersonalityType TargetPersonality { get; set; }
    [Key(18)]
    public TargetTribeType TargetTribe { get; set; }
    [Key(19)]
    public string[] TargetObjectUids { get; set; }
}
