using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqDrawBingo {
    [Key(0)]
    public int BingoEventUid { get; set; }
    [Key(1)]
    public int DrawCount { get; set; }
}
