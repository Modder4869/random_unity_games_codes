using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestRemoveGoods {
    [Key(0)]
    public Goods[] GoodsArray { get; set; }
}
