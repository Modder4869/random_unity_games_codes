using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqReceiveCouponReward {
    [Key(0)]
    public string CouponCode { get; set; }
}
