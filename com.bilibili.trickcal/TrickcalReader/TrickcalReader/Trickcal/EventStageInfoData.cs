using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class EventStageInfoData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int PrevStageUid { get; set; }
    [Key(2)]
    public EventStageType Type { get; set; }
    [Key(3)]
    public int EpisodeValue { get; set; }
    [Key(4)]
    public int DropUid { get; set; }
}
