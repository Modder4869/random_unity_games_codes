using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqSellGoods {
    [Key(0)]
    public List<Goods> GoodsList { get; set; }
}
