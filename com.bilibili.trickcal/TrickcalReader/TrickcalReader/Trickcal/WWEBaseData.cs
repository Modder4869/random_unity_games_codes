using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class WWEBaseData : TableItem<TableData> {
    [Key(0)]
    public float Frame { get; set; }
}
