using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class RanMiniGameFeverData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int TotalGauge { get; set; }
    [Key(2)]
    public int GaugeDecreaseTime { get; set; }
    [Key(3)]
    public int GaugeDecreaseRate { get; set; }
    [Key(4)]
    public int GivenScore { get; set; }
    [Key(5)]
    public int AppearSpeedIncrease { get; set; }
    [Key(6)]
    public int FeverRatePerCombo { get; set; }
    [Key(7)]
    public int FeverRatePerTime { get; set; }
    [Key(8)]
    public int AppearRateIncrease { get; set; }
    [Key(9)]
    public int AppearAmountIncrease { get; set; }
    [Key(10)]
    public float AppearLatencyTime { get; set; }
    [Key(11)]
    public int ModeUid { get; set; }
    [Key(12)]
    public bool IsStopTime { get; set; }
    [Key(13)]
    public RanMiniGameFeverEndSkillType MiniGameFeverEndSkill { get; set; }
}
