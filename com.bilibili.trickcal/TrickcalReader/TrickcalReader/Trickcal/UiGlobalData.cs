using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class UiGlobalData : TableItem<TableData> {
    [Key(0)]
    public string Key { get; set; }
    [Key(1)]
    public float Value { get; set; }
    [Key(2)]
    public string Desc { get; set; }
}
