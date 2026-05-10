using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PnItemRecall {
    [Key(0)]
    public int[] UsedItemIds { get; set; }
    [Key(1)]
    public int[] UsedItemCounts { get; set; }
    [Key(2)]
    public int[] GainedItemIds { get; set; }
    [Key(3)]
    public int[] GainedItemCounts { get; set; }
}
