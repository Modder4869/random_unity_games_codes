using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class GachaRewardData {
    [Key(0)]
    public HeroRewardResult RewardHero { get; set; }
    [Key(1)]
    public GoodsRewardResult RewardGoods { get; set; }
}
