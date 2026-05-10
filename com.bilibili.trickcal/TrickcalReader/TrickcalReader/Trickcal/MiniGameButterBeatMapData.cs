using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class MiniGameButterBeatMapData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int GroupUid { get; set; }
    [Key(2)]
    public ButterMiniGameDifficultyType Difficulty { get; set; }
    [Key(3)]
    public string BeatMapResource { get; set; }
    [Key(4)]
    public string SoundResource { get; set; }
    [Key(5)]
    public string Name { get; set; }
    [Key(6)]
    public int TotalNoteCount { get; set; }
    [Key(7)]
    public int MaxScore { get; set; }
    [Key(8)]
    public string Artist { get; set; }
    [Key(9)]
    public int ResultUnitSkinUid { get; set; }
    [Key(10)]
    public string ResultUnitStanding { get; set; }
}
