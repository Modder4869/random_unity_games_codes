using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrBuyShopItem {
    [Key(0)]
    public List<Goods> RewardList { get; set; }
    [Key(2)]
    public List<HeroRewardResult> HeroRewardList { get; set; }
    [Key(3)]
    public List<Goods> PackageCheckRewardList { get; set; }
}
