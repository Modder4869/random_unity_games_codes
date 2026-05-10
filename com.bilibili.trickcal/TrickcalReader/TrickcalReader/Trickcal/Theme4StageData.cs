using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class Theme4StageData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int Stage { get; set; }
    [Key(2)]
    public int ClearScore { get; set; }
    [Key(3)]
    public int Time { get; set; }
    [Key(4)]
    public int Diagnosis { get; set; }
    [Key(5)]
    public int Enhance { get; set; }
    [Key(6)]
    public int Fake { get; set; }
    [Key(7)]
    public bool[] Tool { get; set; }
    [Key(8)]
    public float[] ToolTime { get; set; }
    [Key(9)]
    public float[] ToolTimeEnhance { get; set; }
    [Key(10)]
    public int Cold { get; set; }
    [Key(11)]
    public int Less { get; set; }
    [Key(12)]
    public int Over { get; set; }
    [Key(13)]
    public int Metal { get; set; }
    [Key(14)]
    public int Back { get; set; }
    [Key(15)]
    public string Desc { get; set; }
    [Key(16)]
    public string[] Rule { get; set; }
    [Key(17)]
    public int NextStageUid { get; set; }
}
