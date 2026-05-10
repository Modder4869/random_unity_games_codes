using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class CookingTycoonEvaluationData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int MaxScore { get; set; }
    [Key(2)]
    public int TypeSubScore { get; set; }
    [Key(3)]
    public int AmountSubScore { get; set; }
    [Key(4)]
    public int ReOrderSubScore { get; set; }
    [Key(5)]
    public int DetailAddScore { get; set; }
    [Key(6)]
    public int PerfectGrade { get; set; }
    [Key(7)]
    public int GoodGrade { get; set; }
    [Key(8)]
    public int NormalGrade { get; set; }
    [Key(9)]
    public int BadGrade { get; set; }
    [Key(10)]
    public int OrderPerfectExtraScore { get; set; }
}
