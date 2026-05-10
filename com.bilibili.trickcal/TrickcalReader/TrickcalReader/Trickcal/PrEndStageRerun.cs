using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrEndStageRerun {
    [Key(0)]
    public bool IsClear { get; set; }
    [Key(1)]
    public List<Goods> ClearRewards { get; set; }
}
