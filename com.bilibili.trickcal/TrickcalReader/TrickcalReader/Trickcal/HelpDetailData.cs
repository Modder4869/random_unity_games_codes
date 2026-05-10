using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class HelpDetailData : TableItem<TableData> {
    [Key(0)]
    public int HelpUid { get; set; }
    [Key(1)]
    public int PageOrder { get; set; }
    [Key(2)]
    public string HelpText { get; set; }
    [Key(3)]
    public string HelpImage { get; set; }
}
