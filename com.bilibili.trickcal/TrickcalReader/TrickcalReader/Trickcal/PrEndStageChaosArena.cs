using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrEndStageChaosArena {
    [Key(0)]
    public bool IsWin { get; set; }
    [Key(1)]
    public int Score { get; set; }
    [Key(2)]
    public bool IsUpdateHighestScore { get; set; }
}
