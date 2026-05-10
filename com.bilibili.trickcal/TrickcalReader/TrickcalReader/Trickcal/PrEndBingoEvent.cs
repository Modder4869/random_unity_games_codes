using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrEndBingoEvent {
    [Key(0)]
    public Goods ExchangeBingoEventCurrency { get; set; }
    [Key(1)]
    public Goods ExchangeResultGoods { get; set; }
    [Key(2)]
    public bool IsEnd { get; set; }
}
