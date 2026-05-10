using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestSetGoods {
    [Key(0)]
    public Goods[] GoodsArray { get; set; }
}
