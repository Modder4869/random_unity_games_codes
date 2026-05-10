using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestAddGoods {
    [Key(0)]
    public Goods[] GoodsArray { get; set; }
}
