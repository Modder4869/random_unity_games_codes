using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class MiniGameEdUnitGachaData : TableItem<TableData> {
    [Key(0)]
    public int MiniGameUid { get; set; }
    [Key(1)]
    public int UnitGradeUid { get; set; }
    [Key(2)]
    public int Ratio { get; set; }
    [Key(3)]
    public int GachaGroup { get; set; }
}
