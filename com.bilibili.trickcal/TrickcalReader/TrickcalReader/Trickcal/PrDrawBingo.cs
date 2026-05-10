using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrDrawBingo {
    [Key(0)]
    public int[] DrawTileLocationIndexs { get; set; }
}
