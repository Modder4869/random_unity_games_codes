using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrBuyGacha {
    [Key(0)]
    public GachaRewardData[] Rewards { get; set; }
    [Key(1)]
    public int RewardGachaMileages { get; set; }
    [Key(2)]
    public int RewardPickUpMileages { get; set; }
    [Key(3)]
    public int RewardFreeMileages { get; set; }
    [Key(4)]
    public int RewardFirstBonusMileage { get; set; }
    [Key(5)]
    public int RewardEventMileages { get; set; }
    [Key(6)]
    public int RewardCardPickUpMileages { get; set; }
    [Key(7)]
    public List<Goods> BonusRewardGoods { get; set; }
    [Key(8)]
    public string AppReviewUrl { get; set; }
}
