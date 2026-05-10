using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestSetMyHomeDonationStartTime {
    [Key(0)]
    public DateTime DonationStartTime { get; set; }
}
