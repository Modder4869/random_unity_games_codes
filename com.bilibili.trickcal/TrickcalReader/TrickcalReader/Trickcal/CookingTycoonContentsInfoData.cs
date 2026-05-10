using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class CookingTycoonContentsInfoData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int ChapterUid { get; set; }
    [Key(2)]
    public int HelpUid { get; set; }
}
