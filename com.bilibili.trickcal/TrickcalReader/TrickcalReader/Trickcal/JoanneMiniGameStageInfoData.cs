using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class JoanneMiniGameStageInfoData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int Time { get; set; }
    [Key(2)]
    public int ZoneGroup { get; set; }
    [Key(3)]
    public int StartZone { get; set; }
}
