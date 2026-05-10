using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class CookingTycoonResultData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int StageUid { get; set; }
    [Key(2)]
    public int MinScore { get; set; }
    [Key(3)]
    public int MaxScore { get; set; }
    [Key(4)]
    public int UnitUid { get; set; }
    [Key(5)]
    public string Ani { get; set; }
    [Key(6)]
    public string Text { get; set; }
    [Key(7)]
    public string Skin { get; set; }
}
