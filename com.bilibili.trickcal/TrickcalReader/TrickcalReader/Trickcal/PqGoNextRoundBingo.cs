using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqGoNextRoundBingo {
    [Key(0)]
    public int BingoEventUid { get; set; }
}
