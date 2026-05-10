using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrStartMiniGame {
    [Key(0)]
    public int StagePlayKey { get; set; }
}
