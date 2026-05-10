using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrGetMyHomeDonationRewards {
    [Key(0)]
    public DateTime ReceiveTime { get; set; }
}
