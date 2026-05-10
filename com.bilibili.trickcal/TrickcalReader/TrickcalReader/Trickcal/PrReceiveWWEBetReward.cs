using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrReceiveWWEBetReward {
    [Key(0)]
    public List<Goods> Rewards { get; set; }
    [Key(1)]
    public Dictionary<WWERewardType, int> RewardCount { get; set; }
}
