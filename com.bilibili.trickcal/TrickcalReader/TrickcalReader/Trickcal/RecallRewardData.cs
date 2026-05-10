using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class RecallRewardData {
    [Key(0)]
    public RecallType RecallType { get; set; }
    [Key(1)]
    public List<Goods> Items { get; set; }
    [Key(2)]
    public int Gold { get; set; }
}
