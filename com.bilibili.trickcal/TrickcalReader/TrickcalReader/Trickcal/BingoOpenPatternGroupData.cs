using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class BingoOpenPatternGroupData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public BingoPatternType PatternType { get; set; }
    [Key(2)]
    public int Season { get; set; }
    [Key(3)]
    public int PatternGroupUid { get; set; }
    [Key(4)]
    public int Ratio { get; set; }
    [Key(5)]
    public int BonusRatio { get; set; }
}
