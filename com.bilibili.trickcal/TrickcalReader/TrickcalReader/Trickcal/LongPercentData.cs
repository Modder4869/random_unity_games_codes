using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class LongPercentData {
    [Key(0)]
    public long Percent { get; set; }
    [Key(1)]
    public long Rate { get; set; }
    [Key(2)]
    public double RateDouble { get; set; }
    [Key(3)]
    public double InverseRateDouble { get; set; }
}
