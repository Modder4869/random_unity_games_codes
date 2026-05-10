using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class GuaranteeData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int GuaranteeMaxGauge { get; set; }
    [Key(2)]
    public GaugeIncreaseType GaugeIncreaseType { get; set; }
    [Key(3)]
    public GaugeResetType GaugeResetType { get; set; }
    [Key(4)]
    public int GaugeResetParam { get; set; }
    [Key(5)]
    public RewardType[] GuaranteeRewardTypes { get; set; }
    [Key(6)]
    public int[] GuaranteeRewardUis { get; set; }
    [Key(7)]
    public int[] GuaranteeRewardValues { get; set; }
}
