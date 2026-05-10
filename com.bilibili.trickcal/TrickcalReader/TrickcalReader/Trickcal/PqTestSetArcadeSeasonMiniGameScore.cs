using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestSetArcadeSeasonMiniGameScore {
    [Key(0)]
    public int Season { get; set; }
    [Key(1)]
    public int Score { get; set; }
}
