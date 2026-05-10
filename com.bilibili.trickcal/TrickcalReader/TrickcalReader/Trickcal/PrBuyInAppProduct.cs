using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrBuyInAppProduct {
    [Key(0)]
    public int CashShopDataUid { get; set; }
    [Key(1)]
    public List<Goods> RewardList { get; set; }
    [Key(2)]
    public Goods[] PackageCheckRewards { get; set; }
    [Key(3)]
    public List<HeroRewardResult> HeroRewardList { get; set; }
    [Key(4)]
    public bool IsPending { get; set; }
    [Key(5)]
    public bool IsFirstBuy { get; set; }
}
