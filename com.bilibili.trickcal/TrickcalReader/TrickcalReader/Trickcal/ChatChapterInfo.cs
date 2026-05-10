using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ChatChapterInfo : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int GroupUid { get; set; }
    [Key(2)]
    public int ChapterOrder { get; set; }
    [Key(3)]
    public string Title { get; set; }
    [Key(4)]
    public bool CanReset { get; set; }
}
