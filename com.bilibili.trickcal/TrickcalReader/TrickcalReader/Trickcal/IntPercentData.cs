using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class IntPercentData {
    [Key(0)]
    public int Percent { get; set; }
    [Key(1)]
    public int Rate { get; set; }
    [Key(2)]
    public double RateDouble { get; set; }
    [Key(3)]
    public double InverseRateDouble { get; set; }
}
