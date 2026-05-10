using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrUseSummonsCard {
    [Key(0)]
    public List<HeroRewardResult> HeroRewardResults { get; set; }
}
