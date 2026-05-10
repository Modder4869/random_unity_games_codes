using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrEndStagePvpArena {
    [Key(0)]
    public List<Goods> RewardList { get; set; }
    [Key(1)]
    public List<Goods> FirstRewardList { get; set; }
    [Key(2)]
    public bool IsWin { get; set; }
}
