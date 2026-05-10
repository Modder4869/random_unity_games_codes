using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class StageRouletteDrawInfo {
    [Key(0)]
    public StageRouletteType[] Types { get; set; }
    [Key(1)]
    public int[] Values { get; set; }
    [Key(2)]
    public int[] Counts { get; set; }
}
