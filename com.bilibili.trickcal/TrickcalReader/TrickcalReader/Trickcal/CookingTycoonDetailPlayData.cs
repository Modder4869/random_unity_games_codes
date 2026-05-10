using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class CookingTycoonDetailPlayData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int ContentsUid { get; set; }
    [Key(2)]
    public int MovingBarSpeed { get; set; }
    [Key(3)]
    public int MovingBarSize { get; set; }
    [Key(4)]
    public int MovingBarMoveTime { get; set; }
    [Key(5)]
    public int GuideAmount { get; set; }
    [Key(6)]
    public int PerfectGuideSize { get; set; }
    [Key(7)]
    public int PerfectAddScore { get; set; }
    [Key(8)]
    public int GoodGuideSize { get; set; }
    [Key(9)]
    public int GoodAddScore { get; set; }
    [Key(10)]
    public int FailSubScore { get; set; }
    [Key(11)]
    public int Pass { get; set; }
    [Key(12)]
    public int GuideAmountMaxPerMoveTime { get; set; }
}
