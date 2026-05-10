using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PuppetStepData : TableItem<TableData> {
    [Key(0)]
    public int EpisodeUid { get; set; }
    [Key(1)]
    public int Uid { get; set; }
    [Key(2)]
    public string Text { get; set; }
    [Key(3)]
    public string Voice { get; set; }
}
