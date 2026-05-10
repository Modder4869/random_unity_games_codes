using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestSetBingoEventOpenPatternGroup {
    [Key(0)]
    public int BingoEventUid { get; set; }
    [Key(1)]
    public int OpenPatternGroupUid { get; set; }
}
