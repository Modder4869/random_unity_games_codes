using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class RanMiniGameBonusData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int Group { get; set; }
    [Key(2)]
    public int Grade { get; set; }
    [Key(3)]
    public int Min { get; set; }
    [Key(4)]
    public int Max { get; set; }
    [Key(5)]
    public int PerScore { get; set; }
}
