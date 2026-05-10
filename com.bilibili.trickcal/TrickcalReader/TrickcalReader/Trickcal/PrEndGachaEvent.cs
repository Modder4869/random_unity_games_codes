using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrEndGachaEvent {
    [Key(0)]
    public List<(Goods, Goods)> CurrencyExchanges { get; set; }
}
