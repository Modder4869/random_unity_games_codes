using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TagResourceData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public string TagHandlerName { get; set; }
    [Key(2)]
    public string TagText { get; set; }
}
