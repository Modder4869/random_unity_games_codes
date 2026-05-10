using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class DrawRateData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int WaveOrder { get; set; }
    [Key(2)]
    public int[] TierRate { get; set; }
}
