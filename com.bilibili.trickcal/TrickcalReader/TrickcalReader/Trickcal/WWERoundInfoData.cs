using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class WWERoundInfoData : TableItem<TableData> {
    [Key(0)]
    public int WWEId { get; set; }
    [Key(1)]
    public int RoundNum { get; set; }
    [Key(2)]
    public WWEStoryBeginType BeginType { get; set; }
    [Key(3)]
    public int StoryUid { get; set; }
}
