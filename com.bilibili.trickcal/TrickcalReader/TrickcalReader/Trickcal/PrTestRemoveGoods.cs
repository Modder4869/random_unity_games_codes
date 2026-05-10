using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrTestRemoveGoods {
    [Key(0)]
    public ResultCode[] GoodsResultCodes { get; set; }
}
