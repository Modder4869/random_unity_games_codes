using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrainingRoomInfo : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public ModeType ModeType { get; set; }
    [Key(2)]
    public int ModeNumber { get; set; }
    [Key(3)]
    public string TrainingRoomName { get; set; }
    [Key(4)]
    public string TrainingRoomDesc { get; set; }
    [Key(5)]
    public int WorldInfo { get; set; }
    [Key(6)]
    public int TrainingRoomWorldUid { get; set; }
    [Key(7)]
    public string TitleSpineAnimation { get; set; }
    [Key(8)]
    public string BGM { get; set; }
}
