using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class GlobalRewardData {
    [Key(0)]
    public bool IsInventoryLimitExceed { get; set; }
    [Key(1)]
    public List<Goods> Rewards { get; set; }
    [Key(2)]
    public List<HeroRewardResult> HeroRewards { get; set; }
    [Key(3)]
    public List<Goods> OverMaxLevelRewards { get; set; }
}
