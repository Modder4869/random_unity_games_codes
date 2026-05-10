using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestSetTrickcalRankScore {
    [Key(0)]
    public int Score { get; set; }
}
