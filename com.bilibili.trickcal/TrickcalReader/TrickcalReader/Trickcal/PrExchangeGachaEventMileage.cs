using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrExchangeGachaEventMileage {
    [Key(0)]
    public HeroRewardResult RewardHero { get; set; }
}
