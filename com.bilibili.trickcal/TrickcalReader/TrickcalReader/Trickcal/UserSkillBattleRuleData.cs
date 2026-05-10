using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class UserSkillBattleRuleData : TableItem<TableData> {
    [Key(0)]
    public int UserSkillGroupUid { get; set; }
    [Key(1)]
    public bool IsGaugeRising { get; set; }
    [Key(2)]
    public float UserSkillGauge { get; set; }
    [Key(3)]
    public float UserSkillSilenceTime { get; set; }
    [Key(4)]
    public float GaugeWaitingTime { get; set; }
    [Key(5)]
    public float GaugeWaitingOperation { get; set; }
    [Key(6)]
    public int UserSkillSilenceSkillUid { get; set; }
    [Key(7)]
    public string UserSkillAutoStrategyType { get; set; }
    [Key(9)]
    public float DefaultUserSkillGauge { get; set; }
    [Key(10)]
    public bool UseSilence { get; set; }
}
