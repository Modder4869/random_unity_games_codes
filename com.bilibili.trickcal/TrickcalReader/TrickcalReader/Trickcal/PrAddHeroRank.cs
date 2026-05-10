using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrAddHeroRank {
    [Key(0)]
    public List<Goods> ReturnItems { get; set; }
}
