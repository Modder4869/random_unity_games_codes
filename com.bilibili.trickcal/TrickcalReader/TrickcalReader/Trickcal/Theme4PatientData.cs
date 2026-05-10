using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class Theme4PatientData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int HeroUid { get; set; }
    [Key(2)]
    public int Stage { get; set; }
    [Key(3)]
    public PatientType Type { get; set; }
    [Key(4)]
    public PatientAnswerType Answer { get; set; }
    [Key(5)]
    public int Score { get; set; }
    [Key(6)]
    public string Question { get; set; }
    [Key(7)]
    public string QuestionAni { get; set; }
    [Key(8)]
    public string Correct { get; set; }
    [Key(9)]
    public string CorrectAni { get; set; }
    [Key(10)]
    public string Wrong { get; set; }
    [Key(11)]
    public string WrongAni { get; set; }
}
