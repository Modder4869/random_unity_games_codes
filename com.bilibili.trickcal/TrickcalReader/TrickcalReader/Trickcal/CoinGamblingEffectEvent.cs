using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class CoinGamblingEffectEvent {
    [Key(0)]
    public int EventIndex { get; set; }
    [Key(1)]
    public TimeSpan ElapsedTime { get; set; }
    [Key(2)]
    public int RandomCountStart { get; set; }
    [Key(3)]
    public int CoinGain { get; set; }
}
