using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrReceiveMailList {
    [Key(0)]
    public List<int> IgnoredMailIdList { get; set; }
    [Key(1)]
    public List<Goods> GoodsList { get; set; }
}
