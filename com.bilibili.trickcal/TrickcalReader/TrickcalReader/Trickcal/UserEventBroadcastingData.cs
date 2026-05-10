using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class UserEventBroadcastingData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public BroadcastingType Type { get; set; }
    [Key(2)]
    public int Condition { get; set; }
    [Key(3)]
    public string TextKey { get; set; }
}
