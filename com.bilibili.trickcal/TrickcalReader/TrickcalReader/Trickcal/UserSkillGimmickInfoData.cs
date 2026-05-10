using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class UserSkillGimmickInfoData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public string MaxGaugeValue { get; set; }
    [Key(2)]
    public AddGaugeTiming AddGaugeTiming { get; set; }
    [Key(3)]
    public string ActivateTakenTime { get; set; }
    [Key(4)]
    public int GimmickSkillUid { get; set; }
    [Key(5)]
    public int GimmickSkillLevel { get; set; }
    [Key(6)]
    public ReleaseConditionType ReleaseConditionType { get; set; }
    [Key(7)]
    public string ReleaseConditionValue { get; set; }
    [Key(8)]
    public string StateChangeActions { get; set; }
    [Key(9)]
    public string PrepareText { get; set; }
    [Key(10)]
    public string ProgressText { get; set; }
    [Key(11)]
    public string UIPreset { get; set; }
}
