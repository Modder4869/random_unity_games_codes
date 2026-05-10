using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqEndBingoEvent {
    [Key(0)]
    public int BingoEventUid { get; set; }
}
