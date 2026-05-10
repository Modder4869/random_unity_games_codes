using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class DefaultTextData : TableItem<TableData> {
    [Key(0)]
    public string Key { get; set; }
    [Key(1)]
    public string KrText { get; set; }
    [Key(2)]
    public string EnText { get; set; }
    [Key(3)]
    public string JpText { get; set; }
    [Key(4)]
    public string ZhChsText { get; set; }
    [Key(5)]
    public string ZhChtText { get; set; }
}
