using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class JoanneMiniGameEndingData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int MinScore { get; set; }
    [Key(2)]
    public int MaxScore { get; set; }
    [Key(3)]
    public int[] SuperUnit { get; set; }
    [Key(4)]
    public int Unit { get; set; }
    [Key(5)]
    public string EndingVoice { get; set; }
    [Key(6)]
    public string EndingLine { get; set; }
    [Key(7)]
    public string EndingTitle { get; set; }
    [Key(8)]
    public string EndingText { get; set; }
    [Key(9)]
    public string Image { get; set; }
    [Key(10)]
    public string Motion { get; set; }
    [Key(11)]
    public JoanneMiniGameEndingConditionType EndingConditionType { get; set; }
    [Key(12)]
    public JoanneUnitGrade EndingConditionValue1 { get; set; }
    [Key(13)]
    public int EndingConditionValue2 { get; set; }
    [Key(14)]
    public string Skin { get; set; }
}
