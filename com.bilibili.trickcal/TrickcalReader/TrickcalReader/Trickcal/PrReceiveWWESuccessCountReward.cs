using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrReceiveWWESuccessCountReward {
    [Key(0)]
    public List<Goods> Rewards { get; set; }
}
