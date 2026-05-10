using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class CookingTycoonQueueData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int Season { get; set; }
    [Key(2)]
    public CookingTycoonOrderType[] QueueOrderType { get; set; }
    [Key(3)]
    public int StageUid { get; set; }
    [Key(4)]
    public int Sort { get; set; }
}
