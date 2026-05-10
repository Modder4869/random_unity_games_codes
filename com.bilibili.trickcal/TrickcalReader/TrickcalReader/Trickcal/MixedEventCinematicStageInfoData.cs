using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class MixedEventCinematicStageInfoData : TableItem<TableData> {
    [Key(0)]
    public int StageUid { get; set; }
    [Key(1)]
    public int EpisodeUid { get; set; }
    [Key(2)]
    public string Background { get; set; }
    [Key(3)]
    public bool IsClearAlarm { get; set; }
    [Key(4)]
    public string ClearIcon { get; set; }
    [Key(5)]
    public string VictoryAllyAnimation { get; set; }
    [Key(6)]
    public string VictoryEnemyAnimation { get; set; }
}
