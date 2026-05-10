using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrDropRatio {
    [Key(0)]
    public Dictionary<int, List<TableBaseDropData>> DropRatio { get; set; }
}
