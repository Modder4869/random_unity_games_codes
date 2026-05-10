using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqExchangeGachaEventMileage {
    [Key(0)]
    public int GachaInfoUid { get; set; }
    [Key(1)]
    public int HeroUid { get; set; }
    [Key(2)]
    public int ExchangeCount { get; set; }
}
