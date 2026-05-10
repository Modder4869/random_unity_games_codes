using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SplitCatalog : TableItem<TableData> {
    [Key(0)]
    public int Id { get; set; }
    [Key(1)]
    public string OriginalFileName { get; set; }
    [Key(2)]
    public string OriginalSheet { get; set; }
    [Key(3)]
    public string SubFileName { get; set; }
    [Key(4)]
    public string SubSheet { get; set; }
    [Key(5)]
    public string UniqueCols { get; set; }
}
