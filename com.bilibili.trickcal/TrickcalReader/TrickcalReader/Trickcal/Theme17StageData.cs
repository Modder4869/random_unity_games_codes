using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class Theme17StageData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int ModeUid { get; set; }
    [Key(2)]
    public int StageOrder { get; set; }
    [Key(3)]
    public int NextStageUid { get; set; }
    [Key(4)]
    public bool Hidden { get; set; }
    [Key(5)]
    public int StartTime { get; set; }
    [Key(6)]
    public int EndTime { get; set; }
    [Key(7)]
    public bool SliderVisible { get; set; }
    [Key(8)]
    public bool TimerVisible { get; set; }
}
