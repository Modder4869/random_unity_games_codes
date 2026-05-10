using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestSwapPvpRanking {
    [Key(0)]
    public int[] TargetRanking { get; set; }
}
