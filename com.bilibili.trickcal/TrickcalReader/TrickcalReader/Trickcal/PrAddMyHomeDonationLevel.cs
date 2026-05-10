using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrAddMyHomeDonationLevel {
    [Key(0)]
    public DateTime ReceiveTime { get; set; }
}
