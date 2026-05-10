using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ChapterManagementData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int MixedEventUid { get; set; }
    [Key(2)]
    public string TitleKey { get; set; }
    [Key(3)]
    public string DescKey { get; set; }
}
