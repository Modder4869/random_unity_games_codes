using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class WaveData : TableItem<TableData> {
    [Key(0)]
    public int StageInfoUid { get; set; }
    [Key(1)]
    public int WaveOrder { get; set; }
    [Key(2)]
    public int TeambuildTime { get; set; }
    [Key(3)]
    public int ClearMana { get; set; }
    [Key(4)]
    public int DropCountMin { get; set; }
    [Key(5)]
    public int DropCountMax { get; set; }
    [Key(6)]
    public int DropGroup { get; set; }
    [Key(7)]
    public int DrawGroup { get; set; }
    [Key(8)]
    public int[] Monster { get; set; }
    [Key(9)]
    public int[] MonsterPosition { get; set; }
    [Key(10)]
    public int[] MonsterValue { get; set; }
    [Key(11)]
    public int[] MonsterLevel { get; set; }
    [Key(13)]
    public StoryBeginType[] StoryBegin { get; set; }
    [Key(14)]
    public int[] StoryUID { get; set; }
    [Key(15)]
    public bool StoryAutoStart { get; set; }
    [Key(16)]
    public int AverageLevel { get; set; }
    [Key(17)]
    public StoryBeginType HelpBegin { get; set; }
    [Key(18)]
    public StageWaveType WaveType { get; set; }
}
