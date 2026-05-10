using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class WWEInfoData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int HelpUid { get; set; }
    [Key(2)]
    public int ChapterUid { get; set; }
}
