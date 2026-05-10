using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestSetCookingTycoonScore {
    [Key(0)]
    public int Season { get; set; }
    [Key(1)]
    public int Score { get; set; }
}
