using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class GachaHistoryData {
    [Key(0)]
    public int Index { get; set; }
    [Key(1)]
    public int GachaId { get; set; }
    [Key(2)]
    public int[] PickedIds { get; set; }
    [Key(3)]
    public int[] PickedCounts { get; set; }
    [Key(4)]
    public int[] PickedReplaceIds { get; set; }
    [Key(5)]
    public int[] PickedReplaceCounts { get; set; }
    [Key(6)]
    public DateTime Time { get; set; }
}
