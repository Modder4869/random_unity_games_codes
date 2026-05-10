using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class StoryData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public StoryType StoryType { get; set; }
    [Key(2)]
    public string StoryName { get; set; }
}
