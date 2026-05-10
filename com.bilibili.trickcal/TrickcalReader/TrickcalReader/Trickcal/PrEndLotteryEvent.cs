using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrEndLotteryEvent {
    [Key(0)]
    public List<(Goods, Goods)> CurrencyExchanges { get; set; }
    [Key(1)]
    public bool IsEnd { get; set; }
}
