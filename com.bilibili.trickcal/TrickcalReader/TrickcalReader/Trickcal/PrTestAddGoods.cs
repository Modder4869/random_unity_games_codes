using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrTestAddGoods {
    [Key(0)]
    public ResultCode[] GoodsResultCodes { get; set; }
}
