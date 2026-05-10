using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqEnterBingoEventFirst {
    [Key(0)]
    public int BingoEventUid { get; set; }
}
