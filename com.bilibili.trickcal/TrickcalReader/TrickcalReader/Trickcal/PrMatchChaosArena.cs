using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrMatchChaosArena {
    [Key(0)]
    public int StagePlayKey { get; set; }
    [Key(1)]
    public ChaosArenaUserData ChaosArenaUserData { get; set; }
}
