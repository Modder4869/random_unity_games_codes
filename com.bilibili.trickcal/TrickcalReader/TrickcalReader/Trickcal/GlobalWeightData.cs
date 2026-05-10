using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class GlobalWeightData : TableItem<TableData> {
    [Key(0)]
    public string Key { get; set; }
    [Key(1)]
    public float Value { get; set; }
}
