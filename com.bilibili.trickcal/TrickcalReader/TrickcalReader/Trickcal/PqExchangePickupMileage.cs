using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqExchangePickupMileage {
    [Key(0)]
    public int Count { get; set; }
    [Key(1)]
    public int ItemUid { get; set; }
}
