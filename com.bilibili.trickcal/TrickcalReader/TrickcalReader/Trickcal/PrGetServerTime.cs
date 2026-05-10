using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrGetServerTime {
    [Key(0)]
    public DateTime ServerTime { get; set; }
}
