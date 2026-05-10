using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserRechargeRebateData {
    [Key(0)]
    public string PlatformId { get; set; }
    [Key(1)]
    public int PayMoneyTotal { get; set; }
    [Key(2)]
    public bool IsFinish { get; set; }
    [Key(3)]
    public DateTime RechargeRebateTime { get; set; }
    [Key(4)]
    public int RebateCashTotal { get; set; }
}
