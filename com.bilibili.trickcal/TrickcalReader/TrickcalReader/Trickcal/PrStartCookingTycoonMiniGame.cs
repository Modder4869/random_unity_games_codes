using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrStartCookingTycoonMiniGame {
    [Key(0)]
    public int StagePlayKey { get; set; }
}
