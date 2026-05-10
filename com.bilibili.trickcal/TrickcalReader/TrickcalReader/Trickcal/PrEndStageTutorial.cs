using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrEndStageTutorial {
    [Key(0)]
    public bool IsClear { get; set; }
    [Key(1)]
    public bool IsFirstClear { get; set; }
    [Key(2)]
    public List<Goods> FirstClearRewards { get; set; }
    [Key(3)]
    public List<Goods> ClearRewards { get; set; }
}
