using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrProcessDayChange {
    [Key(0)]
    public bool IsDayChanged { get; set; }
    [Key(1)]
    public DateTime ServerTime { get; set; }
}
