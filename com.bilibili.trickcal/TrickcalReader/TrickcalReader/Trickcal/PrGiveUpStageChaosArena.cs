using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrGiveUpStageChaosArena {
    [Key(0)]
    public int Score { get; set; }
}
