using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class HeroGrowData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int HeroInfoUid { get; set; }
    [Key(2)]
    public int Cost { get; set; }
    [Key(3)]
    public int Grow { get; set; }
    [Key(4)]
    public TableBaseStatData Stat { get; set; }
}
