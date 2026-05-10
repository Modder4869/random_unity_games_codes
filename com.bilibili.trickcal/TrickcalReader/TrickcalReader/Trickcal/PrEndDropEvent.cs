using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrEndDropEvent {
    [Key(0)]
    public Goods ExchangeDropEventCurrency { get; set; }
    [Key(1)]
    public Goods ExchangeResultGoods { get; set; }
    [Key(2)]
    public bool IsEnd { get; set; }
}
