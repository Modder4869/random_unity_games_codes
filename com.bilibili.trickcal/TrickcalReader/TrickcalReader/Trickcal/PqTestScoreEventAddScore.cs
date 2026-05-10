using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestScoreEventAddScore {
    [Key(0)]
    public int MixedEventUid { get; set; }
    [Key(1)]
    public int Score { get; set; }
}
